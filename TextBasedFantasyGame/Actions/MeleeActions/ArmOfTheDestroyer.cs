using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.MeleeActions
{
    public class ArmOfTheDestroyer : IAction
    {
        public string Name { get; set; } = "Arm of the Destroyer";
        public string Description { get; set; } = "Delivers an Attack with a Potency of 150";
        public int Cooldown { get; set; } = 2;
        public int Potency { get; set; } = 150;
        public int RequiredLevel { get; set; } = 17;
        public DateTime? LastUsed { get; set; }
    }
}