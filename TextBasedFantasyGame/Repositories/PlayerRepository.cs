using System.Data;
using Dapper;
using TextBasedFantasyGame.Models;

namespace TextBasedFantasyGame.Repositories;

public class PlayerRepository
{
    private readonly IDbConnection _conn;

    public PlayerRepository(IDbConnection conn)
    {
        _conn = conn;
    }

    public Player GetPlayerById(int playerId)
    {
        return _conn.QuerySingleOrDefault<Player>("SELECT * FROM Players WHERE PlayerId = @playerId", new { playerId = playerId });
    }    
            
    public IEnumerable<Player>GetAllPlayers()
    {
        return _conn.Query<Player>("SELECT * FROM players");
    }

    public int CreatePlayer(Player newPlayer)
    {
        return _conn.Execute("INSERT INTO Players (PlayerId, Name, CharacterId, Status) VALUES (@playerId, @name, @characterId, @status);",
            new { playerId = newPlayer.PlayerId, name = newPlayer.Name, characterId = newPlayer.CharacterId, status = newPlayer.Status });
    }

    public int UpdatePlayer(Player player)
    {
        return _conn.Execute("UPDATE players SET Name = @name, Status = @status, CharacterId = @characterId WHERE CharacterId = @characterId;",
            new { name = player.Name, status = player.Status, characterId = player.CharacterId });
    }

    public int DeletePlayer(int playerId)
    {
        return _conn.Execute("DELETE FROM Players WHERE PlayerId = @playerId;", new { playerId = playerId});
        //_conn.Execute("DELETE FROM Players WHERE PlayerId = @playerId;", new { playerId = playerId});
    }

    public IEnumerable<Character> GetAllCharactersByPlayerId(int playerId)
    {
        return _conn.Query<Character>(
            "SELECT * FROM Characters WHERE PlayerId = @playerId;",
            new { playerId });
    }
}
