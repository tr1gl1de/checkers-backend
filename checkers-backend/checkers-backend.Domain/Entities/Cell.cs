namespace checkers_backend.Domain.Entities;

public struct Cell
{
    public Cell(int x, int y, Checker? checker)
    {
        X = x;
        Y = y;
        Checker = checker;
    }

    public int X { get; } = 0;

    public int Y { get; } = 0;

    public Checker? Checker { get; } = null;
}