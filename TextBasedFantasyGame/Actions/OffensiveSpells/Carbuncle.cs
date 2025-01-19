using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class Carbuncle : ISpell
    {
        public string Name { get; set; } = "Carbuncle";
        public string Description { get; set; } = "Summons Carbuncle to your side";
        public int Cooldown { get; set; } = 2;
        public int CastTime { get; set; } = 2;
        public int ManaCost { get; set; } = 10;
        public int Potency { get; set; } = 0;
        public int RequiredLevel { get; set; } = 2;
        public DateTime? LastUsed { get; set; }
    }
}