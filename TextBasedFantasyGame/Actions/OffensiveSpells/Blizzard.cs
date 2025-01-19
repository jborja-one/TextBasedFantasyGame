using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class Blizzard : ISpell
    {
        public string Name { get; set; } = "Blizzard";
        public string Description { get; set; } = "Deals 50 potency in ice damage";
        public int Cooldown { get; set; } = 2;
        public int CastTime { get; set; } = 2;
        public int ManaCost { get; set; } = 10;
        public int Potency { get; set; } = 50;
        public int RequiredLevel { get; set; } = 2;
        public DateTime? LastUsed { get; set; }
    }
}