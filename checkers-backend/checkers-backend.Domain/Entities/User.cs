namespace checkers_backend.Domain.Entities;

public class User
{
    public Guid Id { get; } = Guid.NewGuid();
    
    public string Username { get; set; } = string.Empty;
}