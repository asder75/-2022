using System.ComponentModel.DataAnnotations;

namespace BlogBackend.Models.DTOs;

public class UserDto
{
    [Required]
    public Guid Id { get; set; }
    [Required]
    [MinLength(1)]
    public string FullName { get; set; }
    public DateTime? BirthDate { get; set; }
    [Required]
    public Gender Gender { get; set; }
    [Required]
    [MinLength(1)]
    [EmailAddress]
    public string Email { get; set; }
    [Phone]
    public string? PhoneNumber { get; set; }
}