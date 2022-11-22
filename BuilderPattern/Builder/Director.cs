namespace BuilderPattern.Builder;

public class Director
{
    private IBuilder? _builder;

    public void Construct(IBuilder builder)
    {
        _builder = builder;

        builder.StartUpOperations();
        builder.BuildBody();
        builder.InsertWheels();
        builder.AddHeadlights();
        builder.EndOperations();
    }
}
