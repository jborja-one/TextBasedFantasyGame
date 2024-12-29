namespace TextBasedFantasyGame.DTOs;

public class SpellDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int Cooldown { get; set; }
    public int CastTime { get; set; }
    public int ManaCost { get; set;}
    public int Potency { get; set; }
    public int RequiredLevel { get; set; }
}