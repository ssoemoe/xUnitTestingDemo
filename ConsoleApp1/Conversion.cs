using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
    public class Conversion
    {
        public string Name { get; }
        public string Type { get; set; }
        public Conversion(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        public string ToString()
        {
            return Name;
        }
    }
}
