using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.CasterAbilities;

public class Manaward : IAbility
{
    public string Name { get; set; } = "Mana Ward";
    public string Description { get; set; } = "Adds a 100% shield for the caster";
    public int Cooldown { get; set; } = 120;
    public string Effect { get; set; } = "Increases defense by 100% for 20s.";
    public int RequiredLevel { get; set; } = 17;
    public DateTime? LastUsed { get; set; }
    public int EffectDuration { get; set; } = 20;
}