using System;
using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.MeleeActions
{
    public class Overpower : IAction
    {
        public string Name { get; set; } = "Overpower";
        public string Description { get; set; } = "Delivers an Attack with a Potency of 60";
        public int Cooldown { get; set; } = 2;
        public int Potency { get; set; } = 60;
        public int RequiredLevel { get; set; } = 5;
        public DateTime? LastUsed { get; set; }
    }
}