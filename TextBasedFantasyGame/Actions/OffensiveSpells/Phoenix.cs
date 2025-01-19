using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class Phoenix : ISpell
    {
        public string Name { get; set; } = "Summon Phoenix";
        public string Description { get; set; } = "Summons Phoenix and attacks your target with a potency of 180.";
        public int Cooldown { get; set; } = 15;
        public int CastTime { get; set; } = 3;
        public int ManaCost { get; set; } = 30;
        public int Potency { get; set; } = 180;
        public int RequiredLevel { get; set; } = 17;
        public DateTime? LastUsed { get; set; }
    }
}