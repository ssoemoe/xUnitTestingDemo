using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0b_1111;
                int b = a >> 24;
                Display(b);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        static void Display(int x) =>  Console.WriteLine(Convert.ToString(x, 2));
    }
}
