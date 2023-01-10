using BlogBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogBackend.Controllers;

[Route("api/account")]
[ApiController]
[Produces("application/json")]
public class UsersController : ControllerBase
{
    // Properties
    
    
    // Constructor
    public UsersController() {}
    
    // Endpoints
    
    /// <summary>
    /// Register new user
    /// </summary>

    [HttpPost("register")]
    public async Task<IActionResult> RegisterUserBy([FromBody] UserRegisterModel registerData)
    {
        return Ok();
    }

    /// <summary>
    /// Log in to the system
    /// </summary>

    [HttpPost("login")]
    public async Task<IActionResult> LoginUserBy([FromBody] LoginCredentials loginData)
    {
        return Ok();
    }
    
    /// <summary>
    /// Log out system user
    /// </summary>

    [HttpPost("logout")]
    public async Task<IActionResult> LogoutUser()
    {
        return Ok();
    }
    
    /// <summary>
    /// Get user profile
    /// </summary>
    
    [HttpGet("profile")]
    public async Task<IActionResult> GetUserProfile()
    {
        return Ok();
    }
    
    /// <summary>
    /// Edit user profile
    /// </summary>
    
    [HttpPut("profile")]
    public async Task<IActionResult> EditUserProfile([FromBody] UserEditModel editData)
    {
        return Ok();
    }
}