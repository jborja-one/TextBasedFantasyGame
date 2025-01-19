using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.RangedActions
{
    public class RefulgentArrow : IAction
    {
        public string Name { get; set; } = "Refulgent Arrow";
        public string Description { get; set; } = "Delivers an attack with a potency of 220";
        public int Cooldown { get; set; } = 60;
        public int Potency { get; set; } = 220;
        public int RequiredLevel { get; set; } = 20;
        public DateTime? LastUsed { get; set; }
    }
}