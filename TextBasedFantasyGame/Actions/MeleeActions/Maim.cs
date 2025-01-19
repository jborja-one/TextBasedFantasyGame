using System;
using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.MeleeActions
{
    public class Maim : IAction
    {
        public string Name { get; set; } = "Maim";
        public string Description { get; set; } = "Delivers an Attack with a Potency of 30";
        public int Cooldown { get; set; } = 2;
        public int Potency { get; set; } = 30;
        public int RequiredLevel { get; set; } = 3;
        public DateTime? LastUsed { get; set; }
    }
}