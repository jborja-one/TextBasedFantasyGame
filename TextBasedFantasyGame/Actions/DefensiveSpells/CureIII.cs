using System;
using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.DefensiveSpells
{
    public class CureIII : ISpell
    {
        public string Name { get; set; } = "CureIII";
        public string Description { get; set; } = "Heals player with a potency of 120";
        public int Cooldown { get; set; } = 3;
        public int CastTime { get; set; } = 2;
        public int ManaCost { get; set; } = 40;
        public int Potency { get; set; } = 120;
        public int RequiredLevel { get; set; } = 17;
        public DateTime? LastUsed { get; set; }
    }
}