namespace SingletonPattern;

public class SingletonPatternStartup
{
    public void Start()
    {
        Console.WriteLine("************ Singleton Pattern ************");

        Counter counter1 = Counter.GetInstance();
        Counter counter2 = Counter.GetInstance();

        counter1.AddOne();
        counter2.AddOne();

        Console.WriteLine("Counter 1 :"+counter1.Count.ToString());
        Console.WriteLine("Counter 2 :"+counter2.Count.ToString());

        counter1.AddOne();

        Console.WriteLine("Counter 1 :"+counter1.Count.ToString());
        Console.WriteLine("Counter 2 :"+counter2.Count.ToString());
    }
}
