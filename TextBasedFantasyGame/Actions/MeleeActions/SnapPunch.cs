using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.MeleeActions
{
    public class SnapPunch : IAction
    {
        public string Name { get; set; } = "Snap Punch";
        public string Description { get; set; } = "Delivers an Attack with a Potency of 80";
        public int Cooldown { get; set; } = 2;
        public int Potency { get; set; } = 80;
        public int RequiredLevel { get; set; } = 5;
        public DateTime? LastUsed { get; set; }
    }
}