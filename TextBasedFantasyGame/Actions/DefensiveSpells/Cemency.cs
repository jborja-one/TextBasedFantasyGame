using System;
using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.DefensiveSpells
{
    public class Clemency : ISpell
    {
        public string Name { get; set; } = "Clemency";
        public string Description { get; set; } = "Heals the Paladin with a potency of 50";
        public int Cooldown { get; set; } = 2;
        public int CastTime { get; set; } = 2;
        public int ManaCost { get; set; } = 25;
        public int Potency { get; set; } = 50;
        public int RequiredLevel { get; set; } = 15;
        public DateTime? LastUsed { get; set; }
    }
}