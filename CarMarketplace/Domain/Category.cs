namespace Domain;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    
    public ICollection<Car>? Cars { get; set; }
}