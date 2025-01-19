using System;
using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.DefensiveSpells
{
    public class Physic : ISpell
    {
        public string Name { get; set; } = "Physic";
        public string Description { get; set; } = "Heals player with a potency of 100";
        public int Cooldown { get; set; } = 2;
        public int CastTime { get; set; } = 2;
        public int ManaCost { get; set; } = 20;
        public int Potency { get; set; } = 100;
        public int RequiredLevel { get; set; } = 5;
        public DateTime? LastUsed { get; set; }
    }
}