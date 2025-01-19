using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.MeleeActions
{
    public class TrueStrike : IAction
    {
        public string Name { get; set; } = "Ture Strike";
        public string Description { get; set; } = "Delivers an Attack with a Potency of 50";
        public int Cooldown { get; set; } = 2;
        public int Potency { get; set; } = 30;
        public int RequiredLevel { get; set; } = 3;
        public DateTime? LastUsed { get; set; }
    }
}