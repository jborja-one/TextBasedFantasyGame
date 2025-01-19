using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class Glare : ISpell
    {
        public string Name { get; set; } = "Glare";
        public string Description { get; set; } = "Deals 180 potency in holy damage";
        public int Cooldown { get; set; } = 2;
        public int CastTime { get; set; } = 2;
        public int ManaCost { get; set; } = 25;
        public int Potency { get; set; } = 180;
        public int RequiredLevel { get; set; } = 17;
        public DateTime? LastUsed { get; set; }
    }
}