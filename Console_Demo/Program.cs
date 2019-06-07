using System;

namespace Console_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person("Shane", 21);
            //person.Print();

            /*Boxing*/
            object test = new Person("Boxing", 21);
            Person person = (Person)test;// Unboxing
            person.Job = "SDE";
            person.Print();

            //Dynamic
            dynamic d = new Person("Dynamic", 23);
            d.Job = "DBD";
            d.Print();

            var demo = new UnsafeDemo();
            Console.WriteLine(demo.Sum(1, 2));
        }

        // Unsafe mode executes outside of Garbage Collector
        class UnsafeDemo
        {
            public int Sum(int a, int b)
            {
                unsafe
                {
                    int* x = &a, y = &b;
                    return *x + *y;
                }
            }
        }

        public partial class Person
        {
            private string _name;
            public string Name
            {
                get { return _name;  }
                set { _name = value; }
            }
            public int Age { get; set; }
            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

            public void Print()
            {
                Console.WriteLine($"{Name} is {Age} years old and working as {Job}");
            }
        }

        public partial class Person
        {
            public string Job { get; set; }
            public void SetJob(string name)
            {
                this.Job = name;
            }
        }
    }
}