using BlogBackend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogBackend;

public class ApplicationDbContext : IdentityDbContext<User>
{
    // Properties
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Comment> Comments { get; set; }
    
    // Constructor
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
}