namespace BuilderPattern; 

public class MotorCycle : IBuilder
{
    private Product product;
    private string? _brandName;
    public MotorCycle(string brandName)
    {
        product = new();
        _brandName = brandName;
    }

    public void StartUpOperations() => product.Add($"Motor Cycle model name : {_brandName}");
    public void BuildBody() => product.Add("Body of car was added");
    public void InsertWheels() => product.Add("Wheels are added");
    public void AddHeadlights() => product.Add("Headlights are added");
    public Product GetVehicle() => product;
    public void EndOperations() { }
}
