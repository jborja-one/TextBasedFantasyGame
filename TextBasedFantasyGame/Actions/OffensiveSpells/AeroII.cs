using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class AeroII : ISpell
    {
        public string Name { get; set; } = "AeroII";
        public string Description { get; set; } = "Deals 150 potency in wind damage";
        public int Cooldown { get; set; } = 2;
        public int CastTime { get; set; } = 2;
        public int ManaCost { get; set; } = 15;
        public int Potency { get; set; } = 150;
        public int RequiredLevel { get; set; } = 15;
        public DateTime? LastUsed { get; set; }
    }
}