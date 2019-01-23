using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentLibrary;

namespace SystemSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            var componentManager = new ComponentManager();
            List<Hardware> list = new List<Hardware>();

            componentManager.RegisterHeavyHardware("HDD", 200, 400);
            componentManager.RegisterHeavyHardware("SSD", 50, 100);

            Console.ReadKey();
        }
    }
}
