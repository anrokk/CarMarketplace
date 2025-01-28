namespace Domain;

public class Feature
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    
    public ICollection<CarFeature>? CarFeatures { get; set; }
}