using System.Data;
using Dapper;
using TextBasedFantasyGame.Models;

namespace TextBasedFantasyGame.Repositories;

public class UserRepository
{
    private readonly IDbConnection _conn;

    public UserRepository(IDbConnection conn)
    {
        _conn = conn;
    }

    public bool UserExists(string email)
    {
        var count = _conn.ExecuteScalar<int>("SELECT COUNT(1) FROM Users WHERE Email = @email;", new { Email = email });
        return count > 0;
    }

    public User GetUserByEmail(string email)
    {
        return _conn.QuerySingleOrDefault<User>("SELECT * FROM Users WHERE Email = @email;", new { Email = email});
    }

    public User GetUserById(int userId)
    {
        return _conn.QuerySingleOrDefault<User>("SELECT * FROM Users WHERE UserId = @userId", new { UserId = userId });
    }

    public IEnumerable<User> GetAllUsers()
    {
        return _conn.Query<User>("SELECT * FROM User");
    }

    public int SignUp(User newUser)
    {
        return _conn.Execute("INSERT INTO Users(UserId, Email, HashPassword) VALUES (@userId, @email, @hashPassword)",
            new {userId = newUser.UserId, email = newUser.Email, hashPassword = newUser.HashPassword});
    }
}