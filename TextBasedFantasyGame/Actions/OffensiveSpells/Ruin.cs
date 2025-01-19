using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class Ruin : ISpell
    {
        public string Name { get; set; } = "Ruin";
        public string Description { get; set; } = "Deals 50 potency in unaspected damage";
        public int Cooldown { get; set; } = 2;
        public int CastTime { get; set; } = 2;
        public int ManaCost { get; set; } = 10;
        public int Potency { get; set; } = 50;
        public int RequiredLevel { get; set; } = 1;
        public DateTime? LastUsed { get; set; }
    }
}