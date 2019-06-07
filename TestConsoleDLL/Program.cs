using System;
using TestDLL.DemoClasses;
using System.Diagnostics;
using Extensions; // Use the namespace here
using OOP;

namespace Extensions 
{
    public static class StringExtensions
    {
        public static int? LetterCount(this String str)
        {
            char[] chars = str.ToCharArray();
            int? count = 0;
            foreach(char c in chars)
            {
                if (c != ' ') count++;
            }
            return count;
        }
    }
}

namespace OOP {
    public class Person
    {
        public string Name { private set; get; }
        public int Age { private set; get; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // allows the method to be overriden
        public virtual void Promote()
        {
            Console.WriteLine("Promoted!");
        }
        
        public override string ToString()
        {
            return $"[{Name} - {Age}]";
        }

        public string ToString(string type)
        {
            if(type.Equals("json", StringComparison.InvariantCultureIgnoreCase))
            {
                return $"{{name: {Name}, age: {Age}}}";
            }
            return null;
        }
    }

    public interface IHeal
    {
        void Heal();
    }

    public class Doctor : Person, IHeal
    {
        public Doctor(string name, int age) : base(name, age)
        {

        }

        public override void Promote()
        {
            Console.WriteLine("Prmoted to Chief Doctor!");
        }

        public void Heal()
        {
            Console.WriteLine("Healing...");
        }
    }
}

namespace TestConsoleDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Line l1 = new Line(100);
            Line l2 = new Line(987);
            Line newLine = l1 + l2;
            Console.WriteLine(newLine.Length);
            Console.WriteLine(l1 == l2);
        }

        public static void TestParamArray(params int[] digits)
        {
            int? sum = 0;
            foreach(int d in digits)
            {
                sum += d;
            }
            Console.WriteLine(sum);
        }

        public static void TestNullable()
        {
            int? testInt = null;
            int? testVar = testInt ?? -100;
            Console.WriteLine(testVar);
        }

        public static void TestOperators()
        {
            Console.WriteLine($"{typeof(int)} is {sizeof(int)} big" );
            Console.WriteLine(1 == 1 ? true : false);
        }

        public static void TestDuration()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                Object device = new Device($"D-{i}");
                Console.WriteLine(((Device)device).Name);
            }
            stopWatch.Stop();
            TimeSpan objectTs = stopWatch.Elapsed;

            stopWatch.Start();
            for (int j = 0; j < 1000; j++)
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
