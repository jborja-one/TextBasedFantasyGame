namespace TextBasedFantasyGame.DTOs;

public class ActionDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int Cooldown { get; set; }
    public int Potency { get; set; }
    public int RequiredLevel { get; set; }       
}