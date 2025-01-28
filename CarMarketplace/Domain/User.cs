namespace Domain;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = default!;
    public string PasswordHash { get; set; } = default!;
    public string Role { get; set; } = default!;
    
    public ICollection<Car>? Cars { get; set; }
    public ICollection<Purchase>? Purchases { get; set; }
}