using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.MeleeActions
{
    public class FastBlade : IAction
    {
        public string Name { get; set; } = "Fast Blade";
        public string Description { get; set; } = "Delivers an Attack with a Potency of 30";
        public int Cooldown { get; set; } = 2;
        public int Potency { get; set; } = 30;
        public int RequiredLevel { get; set; } = 1;
        public DateTime? LastUsed { get; set; }
    }
}