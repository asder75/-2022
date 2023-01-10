using System.ComponentModel.DataAnnotations;

namespace BlogBackend.Models;

public class CommentDBModel
{
    [Key]
    public Guid Id { get; set; }
    [MinLength(1)]
    public string Content { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public DateTime? DeleteDate { get; set; }
    public Guid AuthorId { get; set; }
    [MinLength(1)]
    public string Author { get; set; }
    public int SubComments { get; set; }
}