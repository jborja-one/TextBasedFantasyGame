using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class EnergyDrain : ISpell
    {
        public string Name { get; set; } = "Energy Dran";
        public string Description { get; set; } = "Drains life from target with a potency of 80";
        public int Cooldown { get; set; } = 2;
        public int CastTime { get; set; } = 2;
        public int ManaCost { get; set; } = 20;
        public int Potency { get; set; } = 80;
        public int RequiredLevel { get; set; } = 3;
        public DateTime? LastUsed { get; set; }
    }
}