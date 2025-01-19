using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.PhysicalAbilities
{
    public class Equilibrium : IAbility
    {
        public string Name { get; set; } = "Equilibrium";
        public string Description { get; set; } = "Heals the warrior with a potency of 150";
        public int Cooldown { get; set; } = 60;
        public string Effect { get; set; } = "Heals the warrior with a potency of 150.";
        public int RequiredLevel { get; set; } = 20;
        public DateTime? LastUsed { get; set; }
        public int EffectDuration { get; set; } = 0;
    }
}