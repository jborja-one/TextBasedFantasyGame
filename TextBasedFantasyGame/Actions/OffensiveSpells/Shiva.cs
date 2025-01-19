using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class Shiva : ISpell
    {
        public string Name { get; set; } = "Summon Shiva";
        public string Description { get; set; } = "Summons Shiva and attacks your target with a potency of 120 with Ice damage";
        public int Cooldown { get; set; } = 15;
        public int CastTime { get; set; } = 3;
        public int ManaCost { get; set; } = 25;
        public int Potency { get; set; } = 120;
        public int RequiredLevel { get; set; } = 10;
        public DateTime? LastUsed { get; set; }
    }
}