namespace TextBasedFantasyGame.DTOs;

public class AbilityDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int Cooldown { get; set; }
    public int RequiredLevel { get; set; }
    public string? Effect { get; set; }
}