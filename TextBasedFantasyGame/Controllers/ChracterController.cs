using Microsoft.AspNetCore.Mvc;
using TextBasedFantasyGame.Models;
using TextBasedFantasyGame.Repositories;

namespace TextBasedFantasyGame.Controllers;

public class ChracterController : ControllerBase
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly CharacterRepository repo;

        public CharacterController(CharacterRepository repo)
        {
            this.repo = repo;
        }

        //GET: api/character/{characterID}
        [HttpGet("{characterId}")]
        public IActionResult GetCharacterById(int characterId)
        {
            var character = repo.GetCharacterById(characterId);
            return Ok(character);
        }

        //GET: api/character
        [HttpGet]
        public IActionResult GetAllCharacters()
        {
            var characters = repo.GetAllCharacters();
            return Ok(characters);
        }

        //POST: api/character
        [HttpPost("createcharacter")]
        public IActionResult CreateCharacter(Character characterToInsert)
        {
            var character = repo.CreateCharacter(characterToInsert);
            return Ok(character);
        }

        //UPDATE: api/character/{characterid}
        [HttpPut("character/{characterId}")]
        public IActionResult UpdateCharcter(Character characterToUpdate)
        {
            var character = repo.UpdateCharacter(characterToUpdate);
            return Ok(character);
        }

        //DELETE api/character/{characterId}
        [HttpDelete("character/{characterId}")]
        public IActionResult DeleteCharacter(int characterId)
        {
            var character = repo.DeleteCharacter(characterId);
            return Ok(character);
        }
    }
}