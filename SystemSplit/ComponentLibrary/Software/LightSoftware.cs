using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentLibrary
{
    public class LightSoftware : Software
    {
        public LightSoftware(string name, int capacityConsumption, int memoryConsumption)
        {
            this.Name = name;
            this.Type = "Light";
            this.CapacityConsumption = capacityConsumption + capacityConsumption / 2;
            this.MemoryConsumption = memoryConsumption / 2;
        }
    }
}
