using System;
using System.Collections.Generic;
using System.Text;

namespace TestDLL.DemoClasses
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle is drawn!");
        }
    }
}
