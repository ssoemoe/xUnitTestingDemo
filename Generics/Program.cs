using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            DevicesManager manager = new DevicesManager();

            for(int i=0; i < 10; i++)
            {
                manager.COMs.Add(new Computer($"COM-{i+1}"));
                manager.Printers.Add(new Printer($"Printer-{i+1}"));
            }

            manager.PrintAllDevices();
        }
    }
}
