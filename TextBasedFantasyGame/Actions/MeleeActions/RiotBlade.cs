using System;
using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.MeleeActions
{
    public class RiotBlade : IAction
    {
        public string Name { get; set; } = "Riot Blade";
        public string Description { get; set; } = "Delivers an Attack with a Potency of 40";
        public int Cooldown { get; set; } = 2;
        public int Potency { get; set; } = 40;
        public int RequiredLevel { get; set; } = 3;
        public DateTime? LastUsed { get; set; }
    }
}