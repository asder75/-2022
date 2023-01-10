using Microsoft.AspNetCore.Identity;

namespace BlogBackend.Database;

public class UserDbModel : IdentityUser
{
    public string FullName { get; set; }
    public DateTime? BirthDate { get; set; }
    public GenderDbModel GenderDbModel { get; set; }

    public List<PostDbModel> PostBy { get; set; } = new();
}