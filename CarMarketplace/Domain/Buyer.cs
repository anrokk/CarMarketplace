namespace Domain;

public class Buyer
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    
    public ICollection<Purchase>? Purchases { get; set; }
}