using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.RangedActions
{
    public class Sidewinder : IAction
    {
        public string Name { get; set; } = "Sidewinder";
        public string Description { get; set; } = "Delivers an attack with a potency of 150";
        public int Cooldown { get; set; } = 60;
        public int Potency { get; set; } = 150;
        public int RequiredLevel { get; set; } = 10;
        public DateTime? LastUsed { get; set; }
    }
}