using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentLibrary
{
    public class CommandManager
    {
        //RegisterHeavyHardware(SSD, 400, 400)
        public void RegisterHeavyHardware(List<Hardware.Hardware> theSystem, string command)
        {
            var splitArray = command.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToArray();

        }
    }
}
