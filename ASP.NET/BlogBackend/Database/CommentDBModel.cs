using System.ComponentModel.DataAnnotations;

namespace BlogBackend.Database;

public class CommentDbModel
{
    [Key]
    public Guid Id { get; set; }
    public Guid? ParentId { get; set; }
    public string Content { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public DateTime? DeleteDate { get; set; }
    public Guid AuthorId { get; set; }
    public string Author { get; set; }
    public int SubComments { get; set; }
}