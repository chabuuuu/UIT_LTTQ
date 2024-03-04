namespace Programming_CSharp
{
    using System;
    using System.Threading;
    class Tester
    {
        private long counter = 0;

        static void Main()
        {
            Tester test = new Tester();
            test.Test();
        }
        void Decrementer()
        {
            try
            {
                Monitor.Enter(this);
               
                if (counter < 10)
                {
                    string threadName = Thread.CurrentThread.Name;

                    //Console.WriteLine(threadName);




                            Console.WriteLine("[{0}] trong Decrementer. Counter:::{1}.", threadName, counter);
                    Monitor.Wait(this);
                }

                while (counter > 0)
                {
                    long temp = counter;
                    temp--;
                    Thread.Sleep(1);
                    counter = temp;
                    Console.WriteLine("[{0}]:::Decrementer --- Counter:::{1} ---",
                    Thread.CurrentThread.Name, counter);
                }
            }
            finally
            {
                Monitor.Exit(this);
            }
        }
        public void Test()
        {
            Thread[] theThreads = {
                new Thread( new ThreadStart(Decrementer) ),
                new Thread( new ThreadStart(Incrementer) ) };
            int ctr = 1;
            foreach (Thread myThread in theThreads)
            {
                myThread.IsBackground = true;
                myThread.Start();
                myThread.Name = "Thread" + ctr.ToString();
                ctr++;
                Console.WriteLine("Bat dau:::thread {0}", myThread.Name);
                Thread.Sleep(50);
            }

            foreach (Thread thread in theThreads)
            {
                thread.Join();
            }
            Console.WriteLine("All threads are done!!!");
        }
        

        void Incrementer()
        {
            try
            {
                Monitor.Enter(this);
                while (counter < 10)
                {
                    string threadName = Thread.CurrentThread.Name;

                    /*
                    string temp = counter.toString();
                    Thread.Sleep(1);
                    */

                    long temp = counter;
                    temp++;
                    Thread.Sleep(1);
                    counter = temp;
                    Console.WriteLine("[{0}]:::Incrementer --- " +
                        "Counter:::{1} ---",threadName, counter);
                }
                // I'm done incrementing for now, let another
                // thread have the Monitor
                Monitor.Pulse(this);


            }
            finally
            {


                Console.WriteLine("[{0}] Dang thoat...",
                Thread.CurrentThread.Name);
                Monitor.Exit(this);
            }
        }
    }
}
