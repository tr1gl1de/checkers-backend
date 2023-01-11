using checkers_backend.Domain.Enums;

namespace checkers_backend.Domain.Entities;

public class GameBoard
{
    public Cell[,] Board { get; } = new Cell[8, 8]
    {
        {
            new(0,0, null), new(1,0, new Checker(Color.Black, CheckerType.Basic)),
            new(2,0, null), new(3,0, new Checker(Color.Black, CheckerType.Basic)),
            new(4,0, null), new(5,0, new Checker(Color.Black, CheckerType.Basic)),
            new(6,0, null), new(7,0, new Checker(Color.Black, CheckerType.Basic))
        },
        {
            new(0, 1, new Checker(Color.Black, CheckerType.Basic)), new(1, 1, null),
            new(2, 1, new Checker(Color.Black, CheckerType.Basic)), new(3, 1, null),
            new(4, 1, new Checker(Color.Black, CheckerType.Basic)), new(5, 1, null),
            new(6, 1, new Checker(Color.Black, CheckerType.Basic)), new(7, 1, null),
        },
        {
            new(0, 2, null), new(1, 2, new Checker(Color.Black, CheckerType.Basic)),
            new(2, 2, null), new(3, 2, new Checker(Color.Black, CheckerType.Basic)),
            new(4, 2, null), new(5, 2, new Checker(Color.Black, CheckerType.Basic)),
            new(6, 2, null), new(7, 2, new Checker(Color.Black, CheckerType.Basic))
        },
        {
            new(0, 3, null), new(1, 3, null),
            new(2, 3, null), new(3, 3, null),
            new(4, 3, null), new(5, 3, null),
            new(6, 3, null), new(7, 3, null),
        },
        {
            new(0, 4, null), new(1, 4, null),
            new(2, 4, null), new(3, 4, null),
            new(4, 4, null), new(5, 4, null),
            new(6, 4, null), new(7, 4, null),
        },
        {
            new(0, 5, new Checker(Color.White, CheckerType.Basic)), new(1, 5, null),
            new(2, 5, new Checker(Color.White, CheckerType.Basic)), new(3, 5, null),
            new(4, 5, new Checker(Color.White, CheckerType.Basic)), new(5, 5, null),
            new(6, 5, new Checker(Color.White, CheckerType.Basic)), new(7, 5, null),
        },
        {
            new(0, 6, null), new(1, 6, new Checker(Color.White, CheckerType.Basic)),
            new(2, 6, null), new(3, 6, new Checker(Color.White, CheckerType.Basic)),
            new(4, 6, null), new(5, 6, new Checker(Color.White, CheckerType.Basic)),
            new(6, 6, null), new(7, 6, new Checker(Color.White, CheckerType.Basic))
        },
        {
            new(0, 7, new Checker(Color.White, CheckerType.Basic)), new(1, 7, null),
            new(2, 7, new Checker(Color.White, CheckerType.Basic)), new(3, 7, null),
            new(4, 7, new Checker(Color.White, CheckerType.Basic)), new(5, 7, null),
            new(6, 7, new Checker(Color.White, CheckerType.Basic)), new(7, 7, null),
        }
    };
}
