using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.PhysicalAbilities
{
    public class SteeledMeditation : IAbility
    {
        public string Name { get; set; } = "Steeled Meditation";
        public string Description { get; set; } = "Increases damage dealt by 20% for 20s.";
        public int Cooldown { get; set; } = 60;
        public string Effect { get; set; } = "Increases damage dealt by 20% for 20s.";
        public int RequiredLevel { get; set; } = 8;
        public DateTime? LastUsed { get; set; }
        public int EffectDuration { get; set; } = 20;
    }
}