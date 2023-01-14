using checkers_backend.Domain.Enums;

namespace checkers_backend.Domain.Entities;

public class SessionGame
{
    public SessionGame(GameBoard gameBoard, string ownerUsername)
    {
        GameBoard = gameBoard;
        OwnerUsername = ownerUsername;
    }

    /// <summary>
    /// Game session identifier
    /// </summary>
    public Guid Id { get; } = Guid.NewGuid();

    /// <summary>
    /// Username of creator this game session
    /// </summary>
    public string OwnerUsername { get; }

    /// <summary>
    /// Game field
    /// </summary>
    public GameBoard GameBoard { get; }
    
    /// <summary>
    /// color of player turn
    /// </summary>
    public Color WhoseTurn { get; set; }

    public Player WhitePlayer { get; } = new(Color.White);

    public Player BlackPlayer { get; } = new(Color.Black);
}