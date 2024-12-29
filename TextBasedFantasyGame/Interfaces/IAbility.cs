namespace TextBasedFantasyGame.Interfaces;

public interface IAbility
{
    string Name { get; set; }
    string Description { get; set; }
    int Cooldown { get; set; }                
    int RequiredLevel { get; set; }
    string Effect { get; set; }
    DateTime? LastUsed { get; set; }
}