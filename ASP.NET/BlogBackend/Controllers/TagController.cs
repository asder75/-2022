using Microsoft.AspNetCore.Mvc;

namespace BlogBackend.Controllers;

[Route("api/tag")]
[ApiController]
[Produces("application/json")]
public class TagController : ControllerBase
{
    // Properties
    
    
    // Constructor
    public TagController() {}
    
    // Endpoints

    /// <summary>
    /// Get tag list
    /// </summary>

    [HttpGet]
    public async Task<IActionResult> GetTagList()
    {
        return Ok();
    }
}