namespace TextBasedFantasyGame.Interfaces;

public interface ISpell
{
    string Name { get; set; }
    string Description { get; set; }
    int Cooldown { get; set; }
    int CastTime { get; set; }
    int ManaCost { get; set; }
    int Potency { get; set; }
    int RequiredLevel { get; set; }
    DateTime? LastUsed { get; set; }
}