using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class DevicesManager
    {
        public IList<Device> COMs { set; get; } = new List<Device>() ;
        public IList<Device> Printers { set; get; }  = new List<Device>();

        public void PrintAllDevices()
        {
            PrintDevices("COMs", COMs);
            PrintDevices("Printers", Printers);
        }

        public void PrintDevices(string title, IList<Device> devices)
        {
            Console.WriteLine(title);
            Console.WriteLine("---------");
            foreach (Device device in devices)
            {
                Console.WriteLine(device.Name);
            }
        }

    }
}
