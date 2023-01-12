using checkers_backend.Domain.Entities;
using checkers_backend.Domain.Enums;
using MediatR;

namespace checkers_backend.Application.Game.PIckRandomFirstTurn;

public class PickRandomFirstTurnCommand : IRequest<Color>
{
    public PickRandomFirstTurnCommand(SessionGame sessionGame)
    {
        SessionGame = sessionGame;
    }

    public SessionGame SessionGame { get; }
}