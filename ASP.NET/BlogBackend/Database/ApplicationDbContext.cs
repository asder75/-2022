using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogBackend.Database;

public class ApplicationDbContext : IdentityDbContext<UserDbModel>
{
    public DbSet<UserDbModel> Users { get; set; }
    public DbSet<PostDbModel> Posts { get; set; }
    public DbSet<CommentDbModel> Comments { get; set; }
    public DbSet<TagDbModel> Tags { get; set; }


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}