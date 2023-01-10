using Microsoft.AspNetCore.Identity;

namespace BlogBackend.Models;

public class User : IdentityUser
{
    public string FullName { get; set; }
    public DateTime? BirthDate { get; set; }
    public Gender Gender { get; set; }

    public List<Post> PostBy { get; set; } = new();
}