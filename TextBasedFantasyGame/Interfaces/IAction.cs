namespace TextBasedFantasyGame.Interfaces;

public interface IAction
{
    string Name { get; set; }
    string Description { get; set; }
    int Cooldown { get; set; }		
    int Potency { get; set; }
    int RequiredLevel { get; set; }
    DateTime? LastUsed { get; set; }
}