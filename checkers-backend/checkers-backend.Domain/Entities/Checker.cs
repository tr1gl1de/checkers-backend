using checkers_backend.Domain.Enums;

namespace checkers_backend.Domain.Entities;

public struct Checker
{
    public Checker(Color color, CheckerType type)
    {
        Color = color;
        Type = type;
    }

    public Color Color { get; }
    
    public CheckerType Type { get; set; }
}