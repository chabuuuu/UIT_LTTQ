using System;
using System.Threading;

public class HoldIntegerUnsynchronized
{
    private int buffer = -1;

    public int Buffer
    {
        get
        {
            /*static void ThreadProc(Object stateInfo)
{ 
    Console.WriteLine("Hi, from thread pool here! ");*/
            Console.WriteLine("*************************");
    
            Console.WriteLine(Thread.CurrentThread.Name + " reads:::" + buffer);

            return buffer;
        }

        set
        {
            Console.WriteLine("**************************");

            Console.WriteLine(Thread.CurrentThread.Name + " writes:::" + value);

            buffer = value;
        }
    }
}

class Producer
{
    private HoldIntegerUnsynchronized sharedLocation;
    private Random randomSleepTime;

    public Producer(HoldIntegerUnsynchronized shared, Random random)
    {
        sharedLocation = shared;
        randomSleepTime = random;
    }

    public void Produce()
    {
        for (int count = 1; count <= 4; count++)
        {
            Thread.Sleep(randomSleepTime.Next(1, 3000));
            sharedLocation.Buffer = count;
        }
        Console.WriteLine("--------------------------");

        Console.WriteLine(Thread.CurrentThread.Name + " done producing.\nTerminating " + Thread.CurrentThread.Name + ".");
        Console.WriteLine("--------------------------");

    }
}

class Consumer
{
    private HoldIntegerUnsynchronized sharedLocation;
    private Random randomSleepTime;

    public Consumer(HoldIntegerUnsynchronized shared, Random random)
    {
        sharedLocation = shared;
        randomSleepTime = random;
    }

    public void Consume()
    {
        int sum = 0;

        for (int count = 1; count <= 4; count++)
        {
            Thread.Sleep(randomSleepTime.Next(1, 3000));
            sum += sharedLocation.Buffer;
        }

        Console.WriteLine(Thread.CurrentThread.Name + " read value, total: " + sum + ".\nTerminating " + Thread.CurrentThread.Name + ".");
    }
}

class SharedCell
{
    static void Main(string[] args)
    {
        HoldIntegerUnsynchronized holdInteger = new HoldIntegerUnsynchronized();
        Random random = new Random();

        Producer producer = new Producer(holdInteger, random);
        Consumer consumer = new Consumer(holdInteger, random);

        Thread producerThread = new Thread(new ThreadStart(producer.Produce));
        producerThread.Name = "Producer";

        Thread consumerThread = new Thread(new ThreadStart(consumer.Consume));
        consumerThread.Name = "Consumer";

        producerThread.Start();
        consumerThread.Start();
    }
}
