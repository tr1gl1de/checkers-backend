using checkers_backend.Domain.Entities;
using MediatR;

namespace checkers_backend.Application.Game.Move;

public class MoveCommand : IRequest<SessionGame>
{
    public MoveCommand(User user, SessionGame sessionGame, MoveCoordDto moveCoordDto)
    {
        User = user;
        SessionGame = sessionGame;
        MoveCoordDto = moveCoordDto;
    }

    public User User { get; }
    
    public SessionGame SessionGame { get; }
    
    public MoveCoordDto MoveCoordDto { get; }
}