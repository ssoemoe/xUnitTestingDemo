using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Printer : Device
    {
        public Printer(string name) : base(name)
        {
        }

        public void Print<T> (T document)
        {
            Console.WriteLine("Printed " + document.ToString());
        }
    }
}
