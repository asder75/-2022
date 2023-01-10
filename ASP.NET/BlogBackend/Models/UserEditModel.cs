using System.ComponentModel.DataAnnotations;

namespace BlogBackend.Models;

public class UserEditModel
{
    [Required]
    [MinLength(1)]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [MinLength(1)]
    public string FullName { get; set; }
    public DateTime? BirthDate { get; set; }
    [Required]
    public Gender Gender { get; set; }

    public string? PhoneNumber { get; set; }
}