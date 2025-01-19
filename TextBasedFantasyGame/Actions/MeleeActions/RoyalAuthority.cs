using System;
using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.MeleeActions
{
    public class RoyalAuthority : IAction
    {
        public string Name { get; set; } = "Royal Authority";
        public string Description { get; set; } = "Delivers an Attack with a Potency of 100";
        public int Cooldown { get; set; } = 2;
        public int Potency { get; set; } = 100;
        public int RequiredLevel { get; set; } = 10;
        public DateTime? LastUsed { get; set; }
    }
}