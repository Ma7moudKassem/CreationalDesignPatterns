namespace SingletonPattern;

public class Counter
{
    private Counter() { }

    private static Counter? instance = null;
    public static Counter GetInstance() 
    {
        if(instance == null)
            instance = new Counter();

        return instance; 
    }

    public int Count { get; set; }
    public void AddOne() => Count++;
}
