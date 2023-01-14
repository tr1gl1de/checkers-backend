﻿using checkers_backend.Domain.Enums;
using MediatR;

namespace checkers_backend.Application.Game.ChooseColor;

public class ChooseColorCommandHandler : IRequestHandler<ChooseColorCommand, Color>
{
    public Task<Color> Handle(ChooseColorCommand request, CancellationToken cancellationToken)
    {
        switch (request.Color)
        {
            case Color.Black:
                request.SessionGame.BlackPlayer.Username = request.User.Username;
                break;
            case Color.White:
                request.SessionGame.WhitePlayer.Username = request.User.Username;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        return Task.FromResult(request.Color);
    }
}