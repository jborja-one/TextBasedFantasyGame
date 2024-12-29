using System.Data;
using Dapper;
using TextBasedFantasyGame.Models;

namespace TextBasedFantasyGame.Repositories;

public class CharacterRepository
{
    private readonly IDbConnection _conn;

    public CharacterRepository(IDbConnection conn)
    {
        _conn = conn;
    }

    public Character GetCharacterById(int characterId)
    {            
        return _conn.QuerySingleOrDefault<Character>("SELECT * FROM Characters WHERE CharacterId = @characterId", new {characterID = characterId});
    }

    public IEnumerable<Character> GetAllCharacters()
    {                        
        return _conn.Query<Character>("SELECT * FROM Characters;");
    }

    public int CreateCharacter(Character newCharacter)
    {

        return _conn.Execute("INSERT INTO Characters (Name, Health, Attack, Defense, Mana, Level, JobId, PlayerId) VALUES (@name, 100, 15, 15, 100, 1, @jobId, @PlayerId);",
            new { name = newCharacter.Name, health = 100, attack = 15, deffense = 15, mana = 100, level = 1, jobId = newCharacter.JobId, playerId = newCharacter.PlayerId });
    }

    public int UpdateCharacter(Character character)
    {
        return _conn.Execute("UPDATE Characters SET Name = @name, Health = @health, Attack = @attack, Defense = @defense, Mana = @mana, Level = @level, JobId = @jobId WHERE CharacterId = @characterId;",
            new {name = character.Name, health = character.Health, attack = character.Attack, defense = character.Defense, mana = character.Mana, level = character.Level, jobId = character.JobId, characterId = character.CharacterId});
    }

    public int DeleteCharacter(int characterId)
    {
        return _conn.Execute("DELETE FROM Characters WHERE CharacterId = @characterId;", new { characterId = characterId });
        //_conn.Execute("DELETE FROM Player WHERE CharacterId = @characterId;", new { characterId = characterId });
    }
}
