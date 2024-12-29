namespace TextBasedFantasyGame.Models;

public class User
{
    public int UserId { get; set;  }
    public int PlayerId { get; set; }
    public string Email { get; set; }
    public string HashPassword { get; set; }

    public User(int userId, int playerId, string email, string hashPassword)
    {
        UserId = userId;
        PlayerId = playerId;
        Email = email;
        HashPassword = hashPassword;
    }
}