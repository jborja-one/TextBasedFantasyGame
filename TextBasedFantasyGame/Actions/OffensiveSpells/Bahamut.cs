using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class Bahamut : ISpell
    {
        public string Name { get; set; } = "Summon Bahamut";
        public string Description { get; set; } = "Summons Bahamut and attacks your target with a potency of 200";
        public int Cooldown { get; set; } = 15;
        public int CastTime { get; set; } = 3;
        public int ManaCost { get; set; } = 30;
        public int Potency { get; set; } = 200;
        public int RequiredLevel { get; set; } = 20;
        public DateTime? LastUsed { get; set; }
    }
}