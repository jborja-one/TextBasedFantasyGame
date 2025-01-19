using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class Freeze : ISpell
    {
        public string Name { get; set; } = "Freeze";
        public string Description { get; set; } = "Deals 200 potency in ice damage";
        public int Cooldown { get; set; } = 4;
        public int CastTime { get; set; } = 5;
        public int ManaCost { get; set; } = 30;
        public int Potency { get; set; } = 200;
        public int RequiredLevel { get; set; } = 19;
        public DateTime? LastUsed { get; set; }
    }
}