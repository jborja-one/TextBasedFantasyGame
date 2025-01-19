using System;
using TextBasedFantasyGame.Interfaces;

namespace TextBasedFantasyGame.Actions.MeleeActions
{
    public class InnerBeast : IAction
    {
        public string Name { get; set; } = "Inner Beast";
        public string Description { get; set; } = "Delivers an Attack with a Potency of 180";
        public int Cooldown { get; set; } = 2;
        public int Potency { get; set; } = 180;
        public int RequiredLevel { get; set; } = 15;
        public DateTime? LastUsed { get; set; }
    }
}