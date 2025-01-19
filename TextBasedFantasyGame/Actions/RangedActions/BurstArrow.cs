using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.RangedActions
{
    public class BurstArrow : IAction
    {
        public string Name { get; set; } = "Burst Arrow";
        public string Description { get; set; } = "Delivers an attack with a potency of 200";
        public int Cooldown { get; set; } = 35;
        public int Potency { get; set; } = 200;
        public int RequiredLevel { get; set; } = 18;
        public DateTime? LastUsed { get; set; }
    }
}