using System;
using System.Threading;

public class HoldIntegerSynchronized
{
    private int buffer = -1;


    private int occupiedBufferCount = 0;

    public int Buffer
    {
        get
        {
            Monitor.Enter(this);



            if (occupiedBufferCount == 0)
            {
                Console.WriteLine("--------------------------------------\n" + Thread.CurrentThread.Name + 
                    ": tries to read." + "\n-------------------------------------");
                DisplayState("Buffer empty.... " + Thread.CurrentThread.Name + " waits...");
                Monitor.Wait(this);
            }



            --occupiedBufferCount;
            DisplayState(Thread.CurrentThread.Name + 
                " reads:::" + buffer );
            Monitor.Pulse(this);

            int bufferCopy = buffer;
            Monitor.Exit(this);

            return bufferCopy;
        }

        set
        {
            Monitor.Enter(this);

            if (occupiedBufferCount == 1)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " tries to write...");
                DisplayState("Buffer full. " + Thread.CurrentThread.Name + " waits...");
                Monitor.Wait(this);
            }

            buffer = value;
            ++occupiedBufferCount;
            DisplayState(Thread.CurrentThread.Name + " writes:::" + buffer);
            Monitor.Pulse(this);

            Monitor.Exit(this);
        }
    }

    public void DisplayState(string operation)
    {
        Console.WriteLine("{0,-35}{1,-9}{2}\n", operation, buffer, occupiedBufferCount);
    }
}

class Producer
{
    private HoldIntegerSynchronized sharedLocation;
    private Random randomSleepTime;

    public Producer(HoldIntegerSynchronized shared, Random random)
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

        Console.WriteLine(Thread.CurrentThread.Name + " done producing.\nTerminating " + Thread.CurrentThread.Name + ".\n");
    }
}

class Consumer
{
    private HoldIntegerSynchronized sharedLocation;
    private Random randomSleepTime;

    public Consumer(HoldIntegerSynchronized shared, Random random)
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
        Console.WriteLine("-------------------------------------");

        Console.WriteLine(
            Thread.CurrentThread.Name + " read values totaling: " 
            + sum + ".\nTerminating " + 
            Thread.CurrentThread.Name );
        Console.WriteLine("-------------------------------------");
    }
}

class SharedCell
{
    static void Main(string[] args)
    {
        HoldIntegerSynchronized holdInteger = new HoldIntegerSynchronized();
        Random random = new Random();

        Producer producer = new Producer(holdInteger, random);
        Consumer consumer = new Consumer(holdInteger, random);

        Console.WriteLine("{0,-35}{1,-9}{2}\n", "Operation", "Buffer", "Occupied Count");
        holdInteger.DisplayState("Initial state");

        Thread producerThread = new Thread(new ThreadStart(producer.Produce)) { Name = "Producer" };
        Thread consumerThread = new Thread(new ThreadStart(consumer.Consume)) { Name = "Consumer" };

        producerThread.Start();
        consumerThread.Start();
    }
}
