using Microsoft.AspNetCore.Mvc;
using TextBasedFantasyGame.DTOs;
using TextBasedFantasyGame.Models;
using TextBasedFantasyGame.Repositories;

namespace TextBasedFantasyGame.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly UserRepository repo;

    public UserController(UserRepository repo)
    {
        this.repo = repo;
    }

    //POST: api/login
    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest loginRequest)
    {
        var user = repo.GetUserByEmail(loginRequest.Email);
        if (user == null || !BCrypt.Net.BCrypt.Verify(loginRequest.Password, user.HashPassword))
        {
            return Unauthorized("Invalid email or password");
        }
        return Ok("Login Successful");
    }

    //POST: api/signup
    [HttpPost("signup")]
    public IActionResult Signup([FromBody] SignupRequest signupRequest)
    {
        if (repo.UserExists(signupRequest.Email))
        {
            return BadRequest("Player with the email address already exists");
        }

        var hashedPassword = BCrypt.Net.BCrypt.HashPassword(signupRequest.Password);
        var newUser = new User(0, 0, signupRequest.Email, hashedPassword);

        repo.SignUp(newUser);

        return Ok("Signup successfull");

    }
}