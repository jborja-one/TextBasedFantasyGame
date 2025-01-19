using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class Ifrit : ISpell
    {
        public string Name { get; set; } = "Summon Ifrit";
        public string Description { get; set; } = "Summons Ifrit and attacks your target with a potency of 100 with fire damage";
        public int Cooldown { get; set; } = 15;
        public int CastTime { get; set; } = 3;
        public int ManaCost { get; set; } = 25;
        public int Potency { get; set; } = 100;
        public int RequiredLevel { get; set; } = 7;
        public DateTime? LastUsed { get; set; }
    }
}