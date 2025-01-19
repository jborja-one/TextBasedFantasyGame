using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class Scathe : ISpell
    {
        public string Name { get; set; } = "Scathe";
        public string Description { get; set; } = "Deals 30 potency in unaspected damage";
        public int Cooldown { get; set; } = 2;
        public int CastTime { get; set; } = 0;
        public int ManaCost { get; set; } = 10;
        public int Potency { get; set; } = 30;
        public int RequiredLevel { get; set; } = 10;
        public DateTime? LastUsed { get; set; }
    }
}