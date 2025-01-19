using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class Thunder : ISpell
    {
        public string Name { get; set; } = "Thunder";
        public string Description { get; set; } = "Deals 55 potency in ice damage";
        public int Cooldown { get; set; } = 2;
        public int CastTime { get; set; } = 2;
        public int ManaCost { get; set; } = 15;
        public int Potency { get; set; } = 55;
        public int RequiredLevel { get; set; } = 7;
        public DateTime? LastUsed { get; set; }
    }
}