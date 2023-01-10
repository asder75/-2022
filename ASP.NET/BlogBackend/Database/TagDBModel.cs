using System.ComponentModel.DataAnnotations;

namespace BlogBackend.Database;

public class TagDbModel
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    
    public List<PostDbModel> Movies { get; set; } = new();
}