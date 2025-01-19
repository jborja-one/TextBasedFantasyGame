using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class StoneII : ISpell
    {
        public string Name { get; set; } = "StoneII";
        public string Description { get; set; } = "Deals 120 potency in earth damage";
        public int Cooldown { get; set; } = 2;
        public int CastTime { get; set; } = 2;
        public int ManaCost { get; set; } = 20;
        public int Potency { get; set; } = 120;
        public int RequiredLevel { get; set; } = 13;
        public DateTime? LastUsed { get; set; }
    }
}