using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.MeleeActions
{
    public class BootShine : IAction
    {
        public string Name { get; set; } = "Boot Shine";
        public string Description { get; set; } = "Delivers an Attack with a Potency of 30";
        public int Cooldown { get; set; } = 2;
        public int Potency { get; set; } = 20;
        public int RequiredLevel { get; set; } = 1;
        public DateTime? LastUsed { get; set; }
    }
}