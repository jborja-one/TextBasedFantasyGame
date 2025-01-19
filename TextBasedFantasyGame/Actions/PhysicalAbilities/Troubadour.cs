using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.PhysicalAbilities
{
    public class Troubadour : IAbility
    {
        public string Name { get; set; } = "Troubadour";
        public string Description { get; set; } = "Reduces damage taken by self by 15%";
        public int Cooldown { get; set; } = 60;
        public string Effect { get; set; } = "Increases defense by 15%";
        public int RequiredLevel { get; set; } = 15;
        public DateTime? LastUsed { get; set; }
        public int EffectDuration { get; set; } = 15;
    }
}