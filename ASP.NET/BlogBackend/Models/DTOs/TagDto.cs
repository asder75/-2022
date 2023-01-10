using System.ComponentModel.DataAnnotations;

namespace BlogBackend.Models.DTOs;

public class TagDto
{
    [Required]
    public Guid Id { get; set; }
    [Required]
    [MinLength(1)]
    public string Name { get; set; }
}