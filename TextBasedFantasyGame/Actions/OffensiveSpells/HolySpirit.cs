using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class HolySpirit : ISpell
    {
        public string Name { get; set; } = "Holy Spirit";
        public string Description { get; set; } = "Deals 150 potency in holy damage";
        public int Cooldown { get; set; } = 2;
        public int CastTime { get; set; } = 2;
        public int ManaCost { get; set; } = 20;
        public int Potency { get; set; } = 150;
        public int RequiredLevel { get; set; } = 12;
        public DateTime? LastUsed { get; set; }
    }
}