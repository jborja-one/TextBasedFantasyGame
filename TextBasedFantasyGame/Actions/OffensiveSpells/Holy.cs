using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class Holy : ISpell
    {
        public string Name { get; set; } = "Holy";
        public string Description { get; set; } = "Deals 200 potency in holy damage";
        public int Cooldown { get; set; } = 2;
        public int CastTime { get; set; } = 2;
        public int ManaCost { get; set; } = 40;
        public int Potency { get; set; } = 200;
        public int RequiredLevel { get; set; } = 20;
        public DateTime? LastUsed { get; set; }
    }
}