using checkers_backend.Domain.Entities;

namespace TestGame;

internal static class Program
{
    public static void Main(string[] args)
    {
        var gameBoard = new GameBoard();
        for (int y = 0; y < 8; y++)
        {
            for (int x = 0; x < 8; x++)
            {
                var checker = gameBoard.Board[y,x].Checker;
                if (checker is null)
                {
                    Console.Write("o");
                    continue;
                }
                Console.Write("x");
            }
            Console.Write(Environment.NewLine);
        }
    }
}