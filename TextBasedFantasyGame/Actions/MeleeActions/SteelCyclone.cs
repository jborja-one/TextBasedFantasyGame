using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.MeleeActions
{
    public class SteelCyclone : IAction
    {
        public string Name { get; set; } = "Steel Cyclone";
        public string Description { get; set; } = "Delivers an Attack with a Potency of 150";
        public int Cooldown { get; set; } = 2;
        public int Potency { get; set; } = 150;
        public int RequiredLevel { get; set; } = 13;
        public DateTime? LastUsed { get; set; }
    }
}