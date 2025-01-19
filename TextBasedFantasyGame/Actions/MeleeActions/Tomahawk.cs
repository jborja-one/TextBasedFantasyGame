using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.MeleeActions
{
    public class Tomahawk : IAction
    {
        public string Name { get; set; } = "Tomahawk";
        public string Description { get; set; } = "Delivers an Attack with a Potency of 100";
        public int Cooldown { get; set; } = 2;
        public int Potency { get; set; } = 100;
        public int RequiredLevel { get; set; } = 7;
        public DateTime? LastUsed { get; set; }
    }
}