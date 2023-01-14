using checkers_backend.Domain.Entities;

namespace TestGame;

internal static class Program
{
    public static void Main(string[] args)
    {
        // var dict = new Dictionary<string,A>();
        // var objectA = new A()
        // {
        //     Bclass = new B()
        //     {
        //         num = 10
        //     }
        // };
        // dict.Add("some",objectA);
        //
        // ChangeB(dict["some"]);
        //
        // Console.WriteLine(dict["some"]);
        //
        // Console.WriteLine(objectA.Bclass.num);
        
        var gameBoard = new GameBoard();
        for (int y = 0; y < 8; y++)
        {
            for (int x = 0; x < 8; x++)
            {
                var checker = gameBoard.Board[y,x];
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

    public static void ChangeB(A a)
    {
        a.Bclass.num = 123;
    }

    internal class A
    {
        public B Bclass { get; set; }
    }

    internal class B
    {
        public int num { get; set; }
    }
}