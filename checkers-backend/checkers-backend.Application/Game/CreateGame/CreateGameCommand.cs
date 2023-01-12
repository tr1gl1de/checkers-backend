﻿using checkers_backend.Domain.Entities;
using checkers_backend.Domain.Enums;
using MediatR;

namespace checkers_backend.Application.Game.CreateGame;

public class CreateGameCommand : IRequest<SessionGame>
{
    public CreateGameCommand(User user)
    {
        User = user;
    }
    
    public User User { get; }
}