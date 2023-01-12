using checkers_backend.Domain.Enums;

namespace checkers_backend.Domain.Entities;

public class Player
{
    public Player(Color color, string? username = null)
    {
        Color = color;
        Username = username;
    }

    public Guid Id { get; } = Guid.NewGuid();

    public Color Color { get; set; }

    public string? Username { get; set; } = null;
}