using System;
using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.MeleeActions
{
    public class InnerChaos : IAction
    {
        public string Name { get; set; } = "Inner Chaos";
        public string Description { get; set; } = "Delivers an Attack with a Potency of 200";
        public int Cooldown { get; set; } = 2;
        public int Potency { get; set; } = 200;
        public int RequiredLevel { get; set; } = 17;
        public DateTime? LastUsed { get; set; }
    }
}