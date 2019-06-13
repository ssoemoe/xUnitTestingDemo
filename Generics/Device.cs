using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Device
    {
        public string Name { get; private set; }
        public Device(string name)
        {
            this.Name = name;
        }

        public void Run()
        {
            Console.WriteLine($"{Name} is running...");
        }

        public void Stop()
        {
            Console.WriteLine($"Stopped {Name}");
        }

        public void Restart()
        {
            Stop();
            Run();
        }
    }
}
