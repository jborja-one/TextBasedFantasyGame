using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class Painflare : ISpell
    {
        public string Name { get; set; } = "Painflare";
        public string Description { get; set; } = "Deals 170 potency in unaspected damage";
        public int Cooldown { get; set; } = 2;
        public int CastTime { get; set; } = 0;
        public int ManaCost { get; set; } = 25;
        public int Potency { get; set; } = 170;
        public int RequiredLevel { get; set; } = 15;
        public DateTime? LastUsed { get; set; }
    }
}