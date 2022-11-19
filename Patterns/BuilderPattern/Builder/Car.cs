namespace BuilderPattern;

public class Car : IBuilder
{
    private Product product;
    private string? _brandName;
    public Car(string brandName)
    {
        product = new();
        _brandName = brandName;
    }

    public void StartUpOperations() => product.Add($"Car model name : {_brandName}");
    public void BuildBody() => product.Add("Body of car was added");
    public void InsertWheels() => product.Add("Wheels are added");
    public void AddHeadlights() => product.Add("Headlights are added");
    public Product GetVehicle() => product;
    public void EndOperations() { }
}
