using checkers_backend.Domain.Entities;
using MediatR;

namespace checkers_backend.Application.Game.CreateGame;

public class CreateGameCommandHandler : IRequestHandler<CreateGameCommand, SessionGame>
{
    public Task<SessionGame> Handle(CreateGameCommand request, CancellationToken cancellationToken)
    {
        var gameSession = new SessionGame(new GameBoard(), ownerUsername: request.User.Username);
        return Task.FromResult(gameSession);
    }
}