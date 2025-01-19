using System;
using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.MeleeActions
{
    public class GoringBlade : IAction
    {
        public string Name { get; set; } = "Goring Blade";
        public string Description { get; set; } = "Delivers an Attack with a Potency of 80";
        public int Cooldown { get; set; } = 2;
        public int Potency { get; set; } = 80;
        public int RequiredLevel { get; set; } = 8;
        public DateTime? LastUsed { get; set; }
    }
}