using System.ComponentModel.DataAnnotations;

namespace BlogBackend.Database;

public class PostDbModel
{
    [Key]
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int ReadingTime { get; set; }
    public string? Image { get; set; }
    public Guid AuthorId { get; set; }
    public string Author { get; set; }
    public int Likes { get; set; }
    public bool HasLike { get; set; }
    public int CommentsCount { get; set; }

    public List<TagDbModel> Tags { get; set; } = new();
    public List<CommentDbModel> Comments { get; set; } = new();
}