using System.ComponentModel.DataAnnotations;

namespace BlogBackend.Models.DTOs;

public class CommentDto
{
    [Required]
    public Guid Id { get; set; }
    [Required]
    [MinLength(1)]
    public string Content { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public DateTime? DeleteDate { get; set; }
    [Required]
    public Guid AuthorId { get; set; }
    [Required]
    [MinLength(1)]
    public string Author { get; set; }
    [Required]
    public int SubComments { get; set; }
}