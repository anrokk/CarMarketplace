namespace Domain;

public class Image
{
    public int Id { get; set; }
    public string ImageUrl { get; set; } = default!;
    public bool IsMainImage { get; set; }
    
    // fk
    public int CarId { get; set; }
    public Car? Car { get; set; }
}