using checkers_backend.Domain.Entities;

namespace checkers_backend.Application.Interfaces;

public interface IMoveService
{
    public bool IsKing(SessionGame sessionGame,byte x, byte y);
    public bool IsKingLine(SessionGame sessionGame,byte x, byte y);
}