using System.ComponentModel.DataAnnotations;

namespace ATM_DEMO_API.DTOs;

public class CardIDAndRSAPublicKeyDto
{
    [Required]
    [StringLength(maximumLength: 19)]
    public string CardID { get; set; }

    [Required]
    public string RSAPublicKey { get; set; }
}
