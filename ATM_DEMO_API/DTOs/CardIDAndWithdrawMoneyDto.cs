using System.ComponentModel.DataAnnotations;

namespace ATM_DEMO_API.DTOs;

public class CardIDAndWithdrawMoneyDto
{
    [Required]
    [StringLength(maximumLength: 19)]
    public string CardID { get; set; }

    [Required]
    public decimal WithdrawAmount { get; set; }
}
