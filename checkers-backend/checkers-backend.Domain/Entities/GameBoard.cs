using checkers_backend.Domain.Enums;

namespace checkers_backend.Domain.Entities;

public class GameBoard
{   
    public Checker?[,] Board { get; } = new Checker?[8, 8]
    {
        {
            null, new(Color.Black, CheckerType.Basic),
            null, new(Color.Black, CheckerType.Basic),
            null, new(Color.Black, CheckerType.Basic),
            null, new(Color.Black, CheckerType.Basic),

        },
        {
            new(Color.Black, CheckerType.Basic), null,
            new(Color.Black, CheckerType.Basic), null,
            new(Color.Black, CheckerType.Basic), null,
            new(Color.Black, CheckerType.Basic), null,
        },
        {
            null, new(Color.Black, CheckerType.Basic),
            null, new(Color.Black, CheckerType.Basic),
            null, new(Color.Black, CheckerType.Basic),
            null, new(Color.Black, CheckerType.Basic),
        },
        {
            null, null,
            null, null,
            null, null,
            null, null,
        },
        {
            null, null,
            null, null,
            null, null,
            null, null,
        },
        {
            new(Color.White, CheckerType.Basic), null,
            new(Color.White, CheckerType.Basic), null,
            new(Color.White, CheckerType.Basic), null,
            new(Color.White, CheckerType.Basic), null,
        },
        {
            null, new(Color.White, CheckerType.Basic),
            null, new(Color.White, CheckerType.Basic),
            null, new(Color.White, CheckerType.Basic),
            null, new(Color.White, CheckerType.Basic),
        },
        {
            new(Color.White, CheckerType.Basic), null,
            new(Color.White, CheckerType.Basic), null,
            new(Color.White, CheckerType.Basic), null,
            new(Color.White, CheckerType.Basic), null,
        }
    };
}
