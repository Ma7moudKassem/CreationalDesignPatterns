namespace SingletonPattern;

public class Counter
{
    private Counter() { }

    private static Counter? instance = null;
    private static object lockObject = new object();
    public static Counter GetInstance()
    {
        if (instance == null)
        {
            lock (lockObject)
            {
                if (instance == null)
                    instance = new Counter();
            }
        }
        return instance;
    }

    public int Count = 0;
    public void AddOne() => Count++;
}
