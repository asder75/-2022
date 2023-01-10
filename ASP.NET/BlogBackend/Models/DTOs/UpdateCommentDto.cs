using System.ComponentModel.DataAnnotations;

namespace BlogBackend.Models.DTOs;

public class UpdateCommentDto
{
    [Required]
    [MinLength(1)]
    public string Content { get; set; }
}