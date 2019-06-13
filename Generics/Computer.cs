using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Computer : Device
    {
        public Computer(string name) : base(name)
        {

        }

        public void Compute<T> (T[] numbers, Func<T[], T> computeMethod)
        {
            T result = computeMethod(numbers);
            Console.WriteLine($"Result: {result}");
        }
    }
}
