using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class Flare : ISpell
    {
        public string Name { get; set; } = "Flare";
        public string Description { get; set; } = "Deals 200 potency in fire damage";
        public int Cooldown { get; set; } = 4;
        public int CastTime { get; set; } = 5;
        public int ManaCost { get; set; } = 30;
        public int Potency { get; set; } = 200;
        public int RequiredLevel { get; set; } = 20;
        public DateTime? LastUsed { get; set; }
    }
}