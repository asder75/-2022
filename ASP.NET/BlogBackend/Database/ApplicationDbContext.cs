using BlogBackend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogBackend;

public class ApplicationDbContext : IdentityDbContext<UserDBModel>
{
    // Properties
    public DbSet<UserDBModel> Users { get; set; }
    public DbSet<PostDBModel> Posts { get; set; }
    public DbSet<TagDBModel> Tags { get; set; }
    public DbSet<CommentDBModel> Comments { get; set; }
    
    // Constructor
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
}