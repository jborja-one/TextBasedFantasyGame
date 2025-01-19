using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.RangedActions
{
    public class EmpyrealArrow : IAction
    {
        public string Name { get; set; } = "Empyreal Arrow";
        public string Description { get; set; } = "Delivers an attack with a potency of 180";
        public int Cooldown { get; set; } = 90;
        public int Potency { get; set; } = 180;
        public int RequiredLevel { get; set; } = 13;
        public DateTime? LastUsed { get; set; }
    }
}