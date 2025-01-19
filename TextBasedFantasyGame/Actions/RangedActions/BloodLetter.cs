using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.RangedActions
{
    public class BloodLetter : IAction
    {
        public string Name { get; set; } = "Bloodletter";
        public string Description { get; set; } = "Delivers an attack with a potency of 45";
        public int Cooldown { get; set; } = 15;
        public int Potency { get; set; } = 45;
        public int RequiredLevel { get; set; } = 6;
        public DateTime? LastUsed { get; set; }        
    }
}