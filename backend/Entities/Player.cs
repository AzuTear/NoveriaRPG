using System.ComponentModel.DataAnnotations;

namespace backend.Entities;

public class Player
{
    public Guid Id { get; set; }

    [Required] [MaxLength(30)] public string? Name { get; set; }

    [Range(1, 99)] public int Level { get; set; } = 1;

    [Range(0, int.MaxValue)] public int Experience { get; set; } = 0;

    public int HitPoints { get; set; }
    public int MaxHitPoints { get; set; }

    public int Strength { get; set; } = 5;
    public int Dexterity { get; set; } = 2;
    public int Agility { get; set; } = 2;

    public List<PlayerResource> Resources { get; set; } = new();
}