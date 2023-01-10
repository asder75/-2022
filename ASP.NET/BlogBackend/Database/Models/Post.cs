using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlogBackend.Models;

public class Post
{
    [Key]
    public Guid Id { get; set; }
    [MinLength(1)]
    public string Title { get; set; }
    [MinLength(1)]
    public string Description { get; set; }
    public int ReadingTime { get; set; }
    public string? Image { get; set; }
    public Guid AuthorID { get; set; }
    [MinLength(1)]
    public string Author { get; set; }
    [DefaultValue(0)]
    public int Likes { get; set; }
    [DefaultValue(false)]
    public bool HasLike { get; set; }
    [DefaultValue(0)]
    public int CommentsCount { get; set; }

    public List<Tag>? Tags { get; set; } = new();
    public List<Comment> Comments { get; set; } = new();
}