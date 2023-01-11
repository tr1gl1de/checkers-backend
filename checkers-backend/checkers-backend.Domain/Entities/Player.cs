using checkers_backend.Domain.Enums;

namespace checkers_backend.Domain.Entities;

public class Player
{
    public Player(Guid id, Color color)
    {
        Id = id;
        Color = color;
    }

    public Guid Id { get; } = Guid.NewGuid();

    public Color Color { get; set; }
}