using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.OffensiveSpells
{
    public class BlizzardII : ISpell
    {
        public string Name { get; set; } = "BlizzardII";
        public string Description { get; set; } = "Deals 120 potency in ice damage";
        public int Cooldown { get; set; } = 4;
        public int CastTime { get; set; } = 4;
        public int ManaCost { get; set; } = 20;
        public int Potency { get; set; } = 120;
        public int RequiredLevel { get; set; } = 15;
        public DateTime? LastUsed { get; set; }
    }
}