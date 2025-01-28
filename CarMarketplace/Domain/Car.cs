using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Car
{
    public int Id { get; set; }

    public string Make { get; set; } = default!; 
    public string Model { get; set; } = default!;
    public int Year { get; set; }
    public decimal Price { get; set; }
    public int Mileage { get; set; }
    [MaxLength(128)]
    public string Color { get; set; } = default!;
    [MaxLength(128)]
    public string Vin { get; set; } = default!;
    public string Description { get; set; } = default!;
    public DateTime ListingDate { get; set; }
    public bool IsSold { get; set; }
    
    // fk
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    
    // fk
    public int SellerId { get; set; }
    public Seller? Seller { get; set; }
    
    // fk
    public int UserId { get; set; }
    public User? User { get; set; }
    
    public ICollection<Purchase>? Purchases { get; set; }
    public ICollection<Image>? Images { get; set; }
    public ICollection<CarFeature>? CarFeatures { get; set; }
}