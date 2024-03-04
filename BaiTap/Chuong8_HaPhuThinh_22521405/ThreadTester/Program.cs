using System;
using System.Threading;

class ThreadTester
{
    static void Main(string[] args)
    {
        MessagePrinter printer1 = new MessagePrinter();
        Thread thread1 = new Thread(new ThreadStart(printer1.Print));
        thread1.Name = "thread1";

        MessagePrinter printer2 = new MessagePrinter();
        Thread thread2 = new Thread(new ThreadStart(printer2.Print));
        thread2.Name = "thread2";

        MessagePrinter printer3 = new MessagePrinter();
        Thread thread3 = new Thread(new ThreadStart(printer3.Print));
        thread3.Name = "thread3";

        Console.WriteLine("Starting threads....");

        thread1.Start();
        thread2.Start();
        thread3.Start();

        Console.WriteLine("Threads has started!!!");
    }
}

class MessagePrinter
{
    private int sleepTime;
    private static Random random = new Random();

    public MessagePrinter()
    {
        sleepTime = random.Next(5001);
    }

    public void Print()
    {
        Thread current = Thread.CurrentThread;

        Console.WriteLine(current.Name + " GOING TO SLEEP, FOR: " + sleepTime);

        Thread.Sleep(sleepTime);

        Console.WriteLine(current.Name + " SLEEP DONE!");
    }
}
