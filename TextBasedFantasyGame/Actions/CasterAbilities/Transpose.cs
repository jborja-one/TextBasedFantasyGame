using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.CasterAbilities;

public class Transpose : IAbility
{
    public string Name { get; set; } = "Transpose";
    public string Description { get; set; } = "Adds 20% potency to the next spell";
    public int Cooldown { get; set; } = 60;
    public string Effect { get; set; } = "Increases the potency of the next spell by 20%";
    public int RequiredLevel { get; set; } = 5;
    public DateTime? LastUsed { get; set; }
    public int EffectDuration { get; set; } = 10;
}