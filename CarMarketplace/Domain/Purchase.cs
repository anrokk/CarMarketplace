namespace Domain;

public class Purchase
{
    public int Id { get; set; }
    public DateTime PurchaseDate { get; set; }
    public decimal PurchasePrice { get; set; }
    
    // fk
    public int CarId { get; set; }
    public Car? Car { get; set; }
    
    // fk
    public int BuyerId { get; set; }
    public Buyer? Buyer { get; set; }
    
    // fk
    public int UserId { get; set; }
    public User? User { get; set; }
}