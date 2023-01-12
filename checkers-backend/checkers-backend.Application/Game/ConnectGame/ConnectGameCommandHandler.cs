using MediatR;

namespace checkers_backend.Application.Game.ConnectGame;

public class ConnectGameCommandHandler : IRequestHandler<ConnectGameCommand, bool>
{
    public Task<bool> Handle(ConnectGameCommand request, CancellationToken cancellationToken)
    {
        try
        {
            request.SessionGame.WhitePlayer.Username ??= request.User.Username;

            request.SessionGame.BlackPlayer.Username ??= request.User.Username;
            
            return Task.FromResult(true);
        }
        catch (Exception)
        {
            return Task.FromResult(false);
        }
    }
}