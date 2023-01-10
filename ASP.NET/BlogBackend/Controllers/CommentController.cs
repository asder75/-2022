using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BlogBackend.Controllers;

[Route("api/comment")]
[ApiController]
[Produces("application/json")]
public class CommentController : ControllerBase
{
    // Properties
    
    
    // Constructor
    public CommentController() {}
    
    // Endpoints
    
    /// <summary>
    /// Get all nested comments(replies)
    /// </summary>
     
    [HttpGet("{id:guid}/tree")]
    public async Task<IActionResult> GetAllCommentsFromPostWith([FromRoute] Guid id)
    {
        return Ok();
    }
    
    /// <summary>
    /// Add a comment to a concrete post
    /// </summary>

    [HttpPost("/api/post/{id:guid}/comment")]
    public async Task<IActionResult> AddCommentToPostWith([FromRoute] Guid id)
    {
        return Ok();
    }
    
    /// <summary>
    /// Edit concrete comment
    /// </summary>

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> EditCommentWith([FromRoute] Guid id)
    {
        return Ok();
    }
    
    /// <summary>
    /// Delete concrete comment
    /// </summary>

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteCommentWith([FromRoute] Guid id)
    {
        return Ok();
    }
}