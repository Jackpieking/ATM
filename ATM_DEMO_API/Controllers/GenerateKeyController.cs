using ATM_DEMO_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace ATM_DEMO_API.Controllers;

[Route(template: "api/[controller]")]
[ApiController]
public class GenerateKeyController : ControllerBase
{
    private readonly RSAEncryptor _rsaEncryptor;

    public GenerateKeyController(RSAEncryptor rsaEncryptor) => _rsaEncryptor = rsaEncryptor;

    [HttpGet(template: "PublicKey")]
    public IActionResult GeneratePublicKey() => Ok(value: _rsaEncryptor.GetPublicKey());
}
