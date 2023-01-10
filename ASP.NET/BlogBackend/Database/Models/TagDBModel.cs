using System.ComponentModel.DataAnnotations;

namespace BlogBackend.Models;

public class TagDBModel
{
    [Key]
    public Guid Id { get; set; }
    [MinLength(1)]
    public string Name { get; set; }
}