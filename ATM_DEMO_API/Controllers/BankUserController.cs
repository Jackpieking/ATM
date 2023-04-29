using ATM_DEMO_API.Data;
using ATM_DEMO_API.DTOs;
using ATM_DEMO_API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace ATM_DEMO_API.Controllers;

[Consumes(contentType: MediaTypeNames.Application.Json)]
[Produces(contentType: MediaTypeNames.Application.Json)]
[Route(template: "api/[controller]")]
[ApiController]
public class BankUserController : ControllerBase
{
    private readonly BankContext _context;
    private readonly RSAEncryptor _rsaEncryptor;
    private readonly IDictionary<string, string> _userRSAPublicKeyDictionary;

    public BankUserController(BankContext context,
                              RSAEncryptor rsaEncryptor,
                              IDictionary<string, string> userRSAPublicKeyDictionary)
    {
        _context = context;
        _rsaEncryptor = rsaEncryptor;
        _userRSAPublicKeyDictionary = userRSAPublicKeyDictionary;
    }

    [HttpDelete("RemoveConnection")]
    public IActionResult RemoveUserAndServerConnection([FromQuery] string cardID)
    {
        var cardIDIsExisted = _userRSAPublicKeyDictionary.ContainsKey(key: cardID);

        if (cardIDIsExisted is true)
            _userRSAPublicKeyDictionary.Remove(key: cardID);

        return NoContent();
    }

    [HttpPost(template: "Validate")]
    public async Task<IActionResult> ValidateUserLoginInfoFromClientAsync([FromBody] string encryptedUserLoginInfo,
                                                                          CancellationToken cancellationToken)
    {
        var userLoginInfoAsJson = _rsaEncryptor.Decrypt(cipherText: encryptedUserLoginInfo);

        var userLoginInfoDto = JsonSerializer.Deserialize(json: userLoginInfoAsJson,
                                                          returnType: typeof(BankUserLoginInfoDTO))
                               as BankUserLoginInfoDTO;

        var foundUserLoginInfo = await
                    _context
                    .BankUserLoginInfo
                    .FirstAsync(predicate: userLoginInfo =>
                                           userLoginInfo.CardID.Equals(userLoginInfoDto.CardID) &&
                                           userLoginInfo.PIN.Equals(userLoginInfoDto.PIN),
                                           cancellationToken: cancellationToken);

        if (foundUserLoginInfo is null)
            return NotFound();

        return NoContent();
    }

    [HttpPost("CreateConnection")]
    public IActionResult CreateConnectionBetweenUserAndServer([FromBody] CardIDAndRSAPublicKeyDto cardIDAndRSAPublicKeyDto)
    {
        _userRSAPublicKeyDictionary.Add(key: cardIDAndRSAPublicKeyDto.CardID,
                                        value: cardIDAndRSAPublicKeyDto.RSAPublicKey);

        return NoContent();
    }

    [HttpGet("UserInfo")]
    public async Task<IActionResult> GetUserInfoByCardIDAsync([FromQuery] string cardID,
                                                              CancellationToken cancellationToken)
    {
        var foundUserInfo = await
            _context
            .BankUserInfo
            .FirstAsync(predicate: userInfo => userInfo.CardID.Equals(cardID),
                        cancellationToken: cancellationToken);

        _userRSAPublicKeyDictionary.TryGetValue(key: cardID,
                                                value: out var rsaPublicKeyByCardID);

        var encryptedBalance = _rsaEncryptor.Encrypt(plainText: foundUserInfo.Money.ToString(),
                                                     publicKey: rsaPublicKeyByCardID);

        return Ok(value: encryptedBalance);
    }

    [HttpPost("Withdraw")]
    public async Task<IActionResult> UpdateUserBalanceAsync([FromBody] string encryptedCardIdAndAmount,
                                                            CancellationToken cancellationToken)
    {
        var cardIDAndWithdrawMoneyDto = JsonSerializer.Deserialize(json: _rsaEncryptor.Decrypt(encryptedCardIdAndAmount),
                                                                   returnType: typeof(CardIDAndWithdrawMoneyDto))
                                        as CardIDAndWithdrawMoneyDto;

        var foundUserInfo = await
            _context
            .BankUserInfo
            .FirstAsync(predicate: userInfo => userInfo.CardID.Equals(cardIDAndWithdrawMoneyDto.CardID),
                        cancellationToken: cancellationToken);

        foundUserInfo.Money -= cardIDAndWithdrawMoneyDto.WithdrawAmount;

        _context.Update(entity: foundUserInfo);
        await _context.SaveChangesAsync(cancellationToken: cancellationToken);

        return NoContent();
    }
}
