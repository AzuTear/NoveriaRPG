namespace backend.Entities;

public class PlayerResource
{
    public Guid Id { get; set; }
    public int Gold { get; set; }
    public int Stamina { get; set; }

    public Guid PlayerId { get; set; }
    public Player Player { get; set; } = null!;
}