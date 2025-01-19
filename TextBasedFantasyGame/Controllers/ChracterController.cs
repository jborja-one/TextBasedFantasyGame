using Microsoft.AspNetCore.Mvc;
using TextBasedFantasyGame.Models;
using TextBasedFantasyGame.Repositories;

namespace TextBasedFantasyGame.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
    private readonly CharacterRepository repo;

    public CharacterController(CharacterRepository repo)
    {
        this.repo = repo;
    }

    // GET: api/character/{characterID}
    [HttpGet("{characterId}")]
    public IActionResult GetCharacterById(int characterId)
    {
        try
        {
            var character = repo.GetCharacterById(characterId);
            if (character == null)
            {
                return NotFound($"Character with ID {characterId} not found.");
            }
            return Ok(character);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    // GET: api/character
    [HttpGet(Name = "GetAllCharacters")]
    public IActionResult Get()
    {
        var characters = repo.GetAllCharacters();
        return Ok(characters); // Returns JSON
    }

    // POST: api/character/createcharacter
    [HttpPost("createcharacter")]
    public IActionResult CreateCharacter([FromBody] Character characterToInsert)
    {
        if (characterToInsert == null)
        {
            return BadRequest("Character data is null.");
        }

        try
        {
            var character = repo.CreateCharacter(characterToInsert);
            return Ok(character);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    // UPDATE: api/character/{characterId}
    [HttpPut("character/{characterId}")]
    public IActionResult UpdateCharacter([FromBody] Character characterToUpdate)
    {
        if (characterToUpdate == null)
        {
            return BadRequest("Character data is null.");
        }

        try
        {
            var character = repo.UpdateCharacter(characterToUpdate);
            if (character == null)
            {
                return NotFound($"Character with ID {characterToUpdate.CharacterId} not found.");
            }
            return Ok(character);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    // DELETE api/character/{characterId}
    [HttpDelete("character/{characterId}")]
    public IActionResult DeleteCharacter(int characterId)
    {
        try
        {
            var character = repo.DeleteCharacter(characterId);
            if (character == null)
            {
                return NotFound($"Character with ID {characterId} not found.");
            }
            return Ok($"Character with ID {characterId} has been deleted.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}
