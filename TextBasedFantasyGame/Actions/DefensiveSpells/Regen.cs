using System;
using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.DefensiveSpells
{
    public class Regen : IAbility
    {
        public string Name { get; set; } = "Regen";
        public string Description { get; set; } = "Recovers 150 health over 15s.";
        public int Cooldown { get; set; } = 30;
        public string Effect { get; set; } = "Recovers 150 health over 15s.";
        public int RequiredLevel { get; set; } = 10;
        public DateTime? LastUsed { get; set; }
        public int EffectDuration { get; set; } = 15;
    }
}