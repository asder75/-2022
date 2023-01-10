using System.Runtime.InteropServices;
using BlogBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BlogBackend.Controllers;

[Route("api/post")]
[ApiController]
[Produces("application/json")]
public class PostController : ControllerBase
{
    // Properties
    
    
    // Constructor
    public PostController() {}
    
    // Endpoints
    
    /// <summary>
    /// Get a list of posts
    /// </summary>
    /// <param name="tags">tag list to filter by tags</param>
    /// <param name="author">part of author name - for filtering by author</param>
    /// <param name="min">minimum reading time in minutes - for filtering by reading time</param>
    /// <param name="max">maximum reading time in minutes - for filtering by reading time</param>
    /// <param name="sorting">option to sort posts</param>
    /// <param name="page">page number</param>
    /// <param name="size">required number of elements per page</param>
    /// <returns></returns>
    
    [HttpGet]
    public async Task<IActionResult> GetListOfPostsBy([FromQuery] List<Guid> tags, string author, int min, int max, PostSorting sorting, int page = 1, int size = 5)
    {
        return Ok();
    }
    
    /// <summary>
    /// Get information about concrete post
    /// </summary>

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetPostBy([FromRoute] Guid id)
    {
        return Ok();
    }
    
    /// <summary>
    /// Add like to concrete post
    /// </summary>

    [HttpPost("{postId:guid}/like")]
    public async Task<IActionResult> AddLikeOnPostWith([FromRoute] Guid postId)
    {
        return Ok();
    }
    
    /// <summary>
    /// Delete like from concrete post
    /// </summary>

    [HttpDelete("{postId:guid}/like")]
    public async Task<IActionResult> DeleteLikeOnPostWith([FromRoute] Guid postId)
    {
        return Ok();
    }
}