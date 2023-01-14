namespace checkers_backend.Application.Game.Move;

public struct MoveCoordDto
{
    public MoveCoordDto(byte checkerX, byte checkerY, byte moveX, byte moveY)
    {
        this.checkerX = checkerX;
        this.checkerY = checkerY;
        this.moveX = moveX;
        this.moveY = moveY;
    }

    public byte checkerX { get; }
    
    public byte checkerY { get; }
    
    public byte moveX { get; }
    
    public byte moveY { get; }
}