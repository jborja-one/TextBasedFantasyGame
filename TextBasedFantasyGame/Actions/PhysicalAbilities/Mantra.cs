using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.PhysicalAbilities
{
    public class Mantra : IAbility
    {
        public string Name { get; set; } = "Mantra";
        public string Description { get; set; } = "Reduces damage taken by 40% for 10s.";
        public int Cooldown { get; set; } = 60;
        public string Effect { get; set; } = "Reduces damage taken by 40% for 10s.";
        public int RequiredLevel { get; set; } = 15;
        public DateTime? LastUsed { get; set; }
        public int EffectDuration { get; set; } = 10;
    }
}