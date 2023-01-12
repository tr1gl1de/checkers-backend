using checkers_backend.Domain.Enums;
using MediatR;

namespace checkers_backend.Application.Game.PIckRandomFirstTurn;

public class PickFirstTurnCommandHandler : IRequestHandler<PickRandomFirstTurnCommand,Color>
{
    public Task<Color> Handle(PickRandomFirstTurnCommand request, CancellationToken cancellationToken)
    {
        var rndColor = new Random().Next(0, 1);
        request.SessionGame.WhoseTurn = (Color) rndColor;
        
        return Task.FromResult(request.SessionGame.WhoseTurn);
    }
}