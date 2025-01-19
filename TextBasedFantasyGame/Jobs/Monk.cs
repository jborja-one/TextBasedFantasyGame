using TextBasedFantasyGame.Models;
using TextBasedFantasyGame.Interfaces;
using TextBasedFantasyGame.Actions.MeleeActions;
using TextBasedFantasyGame.Actions.PhysicalAbilities;

namespace TextBasedFantasyGame.Jobs;

public class Monk : Job
{
    public Monk() { }
    public override void Initialize()
    {
        JobId = 3;
        Name = "Monk";
        Description = "Though now under Garlean rule, the city-state of Ala Mhigo once boasted the greatest military might of all Eorzea. Among its standing armies were the monks—ascetic warriors as dreaded by foes on the field of battle as the city-state's great pikemen.";
        Actions = new List<IAction>
        {
            new BootShine(),
            new TrueStrike(),
            new SnapPunch(),
            new SteelPeak(),
            new TwinSnakes(),
            new ArmOfTheDestroyer(),
            new Demolish(),
            new TornadoKick()
        };
        Abilities = new List<IAbility>
        {
            new SteeledMeditation(),
            new Mantra(),
        };
    }
}