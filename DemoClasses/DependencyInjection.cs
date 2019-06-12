using System;
using System.Collections.Generic;
using System.Text;

namespace TestDLL.DemoClasses
{
    public class DependencyInjection
    {
        // Property Injection
        public IShape _shape { get; set; }
        public DependencyInjection()
        {

        }

        //Constructor Injection
        public DependencyInjection(IShape shape)
        {
            _shape = shape;
        }

        //method injection
        public void RegisterShape(IShape shape)
        {
            _shape = shape;
        }

        public void Draw()
        {
            if (_shape == null) Console.WriteLine("No shape is registered!");
            _shape.Draw();
        }
    }
}
