using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class Fester : ISpell
    {
        public string Name { get; set; } = "Fester";
        public string Description { get; set; } = "Deals 150 potency in unaspected damage";
        public int Cooldown { get; set; } = 2;
        public int CastTime { get; set; } = 0;
        public int ManaCost { get; set; } = 25;
        public int Potency { get; set; } = 150;
        public int RequiredLevel { get; set; } = 13;
        public DateTime? LastUsed { get; set; }
    }
}