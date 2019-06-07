using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Demo
{
    public partial class Person
    {
        public string Job { get; set; }
        public void SetJob(string name)
        {
            this.Job = name;
        }

    }
}
