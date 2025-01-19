using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class FireII : ISpell
    {
        public string Name { get; set; } = "FireII";
        public string Description { get; set; } = "Deals 120 potency in fire damage";
        public int Cooldown { get; set; } = 4;
        public int CastTime { get; set; } = 4;
        public int ManaCost { get; set; } = 20;
        public int Potency { get; set; } = 120;
        public int RequiredLevel { get; set; } = 15;
        public DateTime? LastUsed { get; set; }
    }
}