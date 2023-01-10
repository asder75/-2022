using System.ComponentModel.DataAnnotations;

namespace BlogBackend.Models;

public class Tag
{
    [Key]
    public Guid Id { get; set; }
    [MinLength(1)]
    public string Name { get; set; }
}