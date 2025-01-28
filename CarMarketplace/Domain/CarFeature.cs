namespace Domain;

public class CarFeature
{
    //fk
    public int CarId { get; set; }
    public Car? Car { get; set; }
    
    //fk
    public int FeatureId { get; set; }
    public Feature? Feature { get; set; }
}