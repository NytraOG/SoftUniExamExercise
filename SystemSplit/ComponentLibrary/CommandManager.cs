using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentLibrary.Hardware;

namespace ComponentLibrary
{
    public class CommandManager
    {
        public void RegisterHeavyHardware(List<Hardware.Hardware> theSystem, string command)
        {
            var zwischenspeicher = command.Split('(');
            var zwischenspeicher2 = zwischenspeicher[1].Substring(0, zwischenspeicher[1].Length - 1);
            var splitArray = zwischenspeicher2.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToArray();
            var name = splitArray[0];
            int capacity = Convert.ToInt32(splitArray[1]);
            int memory = Convert.ToInt32(splitArray[2]);
            theSystem.Add(new HeavyHardware(name, capacity, memory));
        }

        public void RegisterPowerHardware(List<Hardware.Hardware> theSystem, string command)
        {
            var zwischenspeicher = command.Split('(');
            var zwischenspeicher2 = zwischenspeicher[1].Substring(0, zwischenspeicher[1].Length - 1);
        }
    }
}
