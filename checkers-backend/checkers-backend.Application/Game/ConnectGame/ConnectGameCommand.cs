using checkers_backend.Domain.Entities;
using MediatR;

namespace checkers_backend.Application.Game.ConnectGame;

public class ConnectGameCommand : IRequest<bool>
{
    public ConnectGameCommand(User user, SessionGame sessionGame)
    {
        User = user;
        SessionGame = sessionGame;
    }

    public User User { get; }
    
    public SessionGame SessionGame { get; }
}