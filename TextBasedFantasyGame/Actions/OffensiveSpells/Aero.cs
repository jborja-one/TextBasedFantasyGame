using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class Aero : ISpell
    {
        public string Name { get; set; } = "Aero";
        public string Description { get; set; } = "Deals 70 potency in wind damage";
        public int Cooldown { get; set; } = 2;
        public int CastTime { get; set; } = 2;
        public int ManaCost { get; set; } = 15;
        public int Potency { get; set; } = 70;
        public int RequiredLevel { get; set; } = 5;
        public DateTime? LastUsed { get; set; }
    }
}