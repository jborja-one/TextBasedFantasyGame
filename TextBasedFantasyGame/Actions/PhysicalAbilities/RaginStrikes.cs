using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.PhysicalAbilities
{
    public class RagingStrikes : IAbility
    {
        public string Name { get; set; } = "Raging Strikes";
        public string Description { get; set; } = "Increases damage dealt by 20% for 20s.";
        public int Cooldown { get; set; } = 120;
        public string Effect { get; set; } = "Increases damage dealt by 20% for 20s.";
        public int RequiredLevel { get; set; } = 4;
        public DateTime? LastUsed { get; set; }
        public int EffectDuration { get; set; } = 20;
    }
}