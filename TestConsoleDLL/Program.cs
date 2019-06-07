using System;
using TestDLL.DemoClasses;
using System.Diagnostics;

namespace TestConsoleDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for(int i=0; i < 1000; i++)
            {
                Object device = new Device($"D-{i}");
                Console.WriteLine( ( (Device) device).Name);
            }
            stopWatch.Stop();
            TimeSpan objectTs = stopWatch.Elapsed;

            stopWatch.Start();
            for(int j = 0; j < 1000; j++)
            {
                var device = new Device("E-" + j);
                Console.WriteLine(device.Name);
            }
            stopWatch.Stop();
            TimeSpan varTs = stopWatch.Elapsed;

            Console.WriteLine("Duration (Boxing/Unboxing): " + objectTs.Milliseconds + " ms");
            Console.WriteLine("Duration (Var): " + varTs.Milliseconds + " ms");
        }
    }
}
