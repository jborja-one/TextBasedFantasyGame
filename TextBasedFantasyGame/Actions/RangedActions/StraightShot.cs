using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.RangedActions
{
    public class StraightShot : IAction
    {
        public string Name { get; set; } = "Straight Shot";
        public string Description { get; set; } = "Delivers an attack with a potency of 20";
        public int Cooldown { get; set; } = 2;
        public int Potency { get; set; } = 20;
        public int RequiredLevel { get; set; } = 2;
        public DateTime? LastUsed { get; set; }        
    }
}