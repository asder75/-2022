using System.ComponentModel.DataAnnotations;

namespace BlogBackend.Models.DTOs;

public class CreateCommentDto
{
    [Required]
    [MinLength(1)]
    public string Content { get; set; }
    public Guid? ParentId { get; set; }
}