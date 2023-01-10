namespace BlogBackend.Models.DTOs;

public class PostPagedListDto
{
    public List<PostDto>? Posts { get; set; }
    public PageInfoModel Pagination { get; set; }
}