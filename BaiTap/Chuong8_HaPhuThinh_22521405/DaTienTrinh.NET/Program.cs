using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread thread = new Thread(new ThreadStart(ExecuteProcess));
        //Thread.Sleep(5000);

        Thread.Sleep(1000);
        thread.Start();
        thread.Join();

        Console.WriteLine("Tiến trình kết thúc!!!");

    }

    static void ExecuteProcess()
    {
        try
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "notepad.exe", 


                Arguments = "example.txt", 


                UseShellExecute = true 
            };

            Process process = new Process
            {
                StartInfo = startInfo
            };
            process.Start();

            //wait for exit process.WaitForExit();
            process.WaitForExit();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}