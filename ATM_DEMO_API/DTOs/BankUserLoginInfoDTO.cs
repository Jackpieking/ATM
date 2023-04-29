using System.ComponentModel.DataAnnotations;

namespace ATM_DEMO_API.DTOs;

public class BankUserLoginInfoDTO
{
    [Required]
    [StringLength(maximumLength: 19)]
    public string CardID { get; set; }

    [Required]
    [StringLength(maximumLength: 6)]
    public string PIN { get; set; }
}
