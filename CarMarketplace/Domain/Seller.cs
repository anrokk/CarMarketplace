namespace Domain;

public class Seller
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;

    public ICollection<Car>? Cars { get; set; }

}