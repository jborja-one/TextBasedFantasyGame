namespace TextBasedFantasyGame.DTOs;

public class JobDto
{
    public int JobId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<ActionDto>? Actions { get; set; }
    public List<AbilityDto>? Abilities { get; set; }
    public List<SpellDto>? Spell { get; set; }
}