using Microsoft.AspNetCore.Mvc;

namespace TextBasedFantasyGame.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        Console.WriteLine("Test API hit");
        return Ok("Test API is working");
    }
}
