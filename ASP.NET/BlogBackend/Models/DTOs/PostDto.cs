using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlogBackend.Models.DTOs;

public class PostDto
{
    [Required]
    public Guid Id { get; set; }
    [Required]
    [MinLength(1)]
    public string Title { get; set; }
    [Required]
    [MinLength(1)]
    public string Description { get; set; }
    [Required]
    public int ReadingTime { get; set; }
    public string? Image { get; set; }
    [Required]
    public Guid AuthorId { get; set; }
    [Required]
    [MinLength(1)]
    public string Author { get; set; }
    [Required]
    [DefaultValue(0)]
    public int Likes { get; set; }
    [Required]
    [DefaultValue(false)]
    public bool HasLike { get; set; }
    [Required]
    [DefaultValue(0)]
    public int CommentsCount { get; set; }
    public List<TagDto>? Tags { get; set; }
}