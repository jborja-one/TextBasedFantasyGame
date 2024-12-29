using Microsoft.AspNetCore.Mvc;
using TextBasedFantasyGame.Models;
using TextBasedFantasyGame.Repositories;

namespace TextBasedFantasyGame.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayerController : ControllerBase
{
    private readonly PlayerRepository repo;

    public PlayerController(PlayerRepository repo)
    {
        this.repo = repo;
    }

    //GET: api/player/{playerId}
    [HttpGet("{playerId}")]
    public IActionResult GetPlayerById(int playerId)
    {
        var player = repo.GetPlayerById(playerId);
        return Ok(player);
    }

    //GET: api/player
    [HttpGet]
    public IActionResult GetAllPlayers()
    {
        var players = repo.GetAllPlayers();
        return Ok(players);
    }

    //POST: api/character
    [HttpPost("createplayer")]
    public IActionResult CreatePlayer(Player playerToCreate)
    {
        var player = repo.CreatePlayer(playerToCreate);
        return Ok(player);
    }

    //UPDATE: api/player/{playerId}
    [HttpPut("{playerId}")]
    public IActionResult UpdatePlayer(Player playerToUpdate)
    {
        var player = repo.UpdatePlayer(playerToUpdate);
        return Ok(player);
    }

    //DELETE: api/{playerId}
    [HttpDelete("{playerId}")]
    public IActionResult DeleteCharacter(int playerId)
    {
        var player = repo.DeletePlayer(playerId);
        return Ok(player);
    }

    //GET: api/allCharacters
    [HttpGet("allCharacters")]
    public IActionResult GetAllCharactersByPlayerId(int playerId)
    {
        var characters = repo.GetAllCharactersByPlayerId(playerId);
        return Ok(characters);
    }
}