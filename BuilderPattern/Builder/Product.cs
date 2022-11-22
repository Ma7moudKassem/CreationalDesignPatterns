namespace BuilderPattern.Builder;

public class Product
{
    private LinkedList<string> parts;
    public Product() => parts = new();

    public void Add(string part)
    {
        parts.AddLast(part);
    }
    public string Show()
    {
        StringBuilder result = new();

        result.AppendLine("Product components are :");

        foreach (string part in parts)
            result.AppendLine(part);

        return result.ToString();
    }
}