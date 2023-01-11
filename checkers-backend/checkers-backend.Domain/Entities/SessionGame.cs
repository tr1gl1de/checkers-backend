namespace checkers_backend.Domain.Entities;

public class SessionGame
{
    public SessionGame(GameBoard gameBoard, Player masterPlayer)
    {
        GameBoard = gameBoard;
        MasterPlayer = masterPlayer;
    }

    /// <summary>
    /// Game session identifier
    /// </summary>
    public Guid Id { get; } = Guid.NewGuid();
    
    /// <summary>
    /// Game field
    /// </summary>
    public GameBoard GameBoard { get; set; }
    
    /// <summary>
    /// Owner game session
    /// </summary>
    public Player MasterPlayer { get; }

    /// <summary>
    /// Guest player
    /// </summary>
    public Player? BasicPlayer { get; set; } = null;
}