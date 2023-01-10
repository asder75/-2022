using System.ComponentModel.DataAnnotations;

namespace BlogBackend.Models;

public class TokenResponse
{
    [Required]
    [MinLength(1)]
    public string Token { get; set; }
}