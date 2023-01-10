using BlogBackend.Models;
using BlogBackend.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BlogBackend.Controllers;

[Route("api/author")]
[ApiController]
public class AuthorController : ControllerBase
{
    // Properties
    
    
    // Constructor
    public AuthorController() {}
    
    //Endpoints
    [HttpGet("list")]
    public async Task<IActionResult> GetListOfAuthors([FromBody] PostDto data)
    {
        return Ok();
    }
}