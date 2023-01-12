using checkers_backend.Domain.Entities;
using checkers_backend.Domain.Enums;
using MediatR;

namespace checkers_backend.Application.Game.ChooseColor;

public class ChooseColorCommand : IRequest
{
    public ChooseColorCommand(Color color, SessionGame sessionGame, User user)
    {
        Color = color;
        SessionGame = sessionGame;
        User = user;
    }

    public User User { get; }
    public SessionGame SessionGame { get; }
    public Color Color { get; }
}