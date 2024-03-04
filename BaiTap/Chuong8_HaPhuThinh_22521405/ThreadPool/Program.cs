using System;
using System.Threading;
public class Example
{
    static void ThreadProc(Object stateInfo)
    {
        Console.WriteLine("Hi, from thread pool here! ");
    }
    public static void Main()
    { 
        ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadProc));
        Console.WriteLine("--- Main thread does some work....Then sleeps.... ---- ");
        
        
        Thread.Sleep(1000);
        Console.WriteLine("--- Main thread exit --- ");
    }

}