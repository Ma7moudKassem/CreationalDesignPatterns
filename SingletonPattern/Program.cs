// With single thread
/*
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
*/

//with multi thread

Task task1 = Task.Factory.StartNew(() =>
{
    Counter counter1 = Counter.GetInstance();
    counter1.AddOne();
    Console.WriteLine("counter 1 :" + counter1.Count.ToString());
});

Task task2 = Task.Factory.StartNew(() =>
{
    Counter counter2 = Counter.GetInstance();
    counter2.AddOne();
    Console.WriteLine("counter 2 :" + counter2.Count.ToString());
    Console.WriteLine();
});