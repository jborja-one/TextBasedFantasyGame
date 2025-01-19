using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.DefensiveSpells
{
    public class CureII : ISpell
    {
        public string Name { get; set; } = "CureII";
        public string Description { get; set; } = "Heals player with a potency of 80";
        public int Cooldown { get; set; } = 3;
        public int CastTime { get; set; } = 2;
        public int ManaCost { get; set; } = 20;
        public int Potency { get; set; } = 80;
        public int RequiredLevel { get; set; } = 7;
        public DateTime? LastUsed { get; set; }
    }
}