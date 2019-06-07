using System;

namespace TestDLL.DemoClasses
{
    public class Device
    {
        public int Count { get; set; }

        public string Name { get;  }

        public Device(string name)
        {
            this.Name = name;
            this.Count = 0;
        }

        public void Print()
        {
            Console.WriteLine($"Testing From Device - {this.Name}");
        }

        public void IncCount()
        {
            this.Count++;
        }

        public int GetCount()
        {
            return this.Count;
        }

    }
}
