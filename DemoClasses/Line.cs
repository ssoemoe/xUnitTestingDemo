using System;
using System.Collections.Generic;
using System.Text;

namespace TestDLL.DemoClasses
{
    // Operator Overloading - C++ feature in C#

    public class Line : IShape
    {
        public double Length { get; }
        public Line(double length)
        {
            this.Length = length;
        }

        public static bool operator == (Line l1, Line l2)
        {
            if (l1.Length == l2.Length) return true;
            return false;
        }

        public static bool operator !=(Line l1, Line l2)
        {
            if (l1.Length != l2.Length) return true;
            return false;
        }

        public static Line operator +(Line l1, Line l2)
        {
            Line newLine = new Line(l1.Length + l2.Length);
            return newLine;
        }

        public void Draw()
        {
            Console.WriteLine("Line is drawn! {0}", Length);
        }
    }
}
