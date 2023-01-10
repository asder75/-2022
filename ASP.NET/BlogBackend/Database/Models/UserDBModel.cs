using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BlogBackend.Models;

public class UserDBModel : IdentityUser
{
    [MinLength(1)]
    [Required]
    public string FullName { get; set; }
    public DateTime? BirthDate { get; set; }
    [Required]
    public GenderDBModel GenderDbModel { get; set; }

    public List<PostDBModel> PostBy { get; set; } = new();
}