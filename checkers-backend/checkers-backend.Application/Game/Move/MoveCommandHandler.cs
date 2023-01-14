using checkers_backend.Domain.Entities;
using checkers_backend.Domain.Enums;
using MediatR;

namespace checkers_backend.Application.Game.Move;

public class MoveCommandHandler : IRequestHandler<MoveCommand, SessionGame>
{
    public Task<SessionGame> Handle(MoveCommand request, CancellationToken cancellationToken)
    {
        if (request.User.Username == request.SessionGame.BlackPlayer.Username && request.SessionGame.WhoseTurn == Color.Black)
        {
            // TODO: Add move implementation
        }

        if (request.User.Username == request.SessionGame.WhitePlayer.Username && request.SessionGame.WhoseTurn == Color.White)
        {
            // TODO: Add move implementation
        }

        // TODO: Remove this after logic is implemented
        return Task.FromResult(request.SessionGame);
    }
}