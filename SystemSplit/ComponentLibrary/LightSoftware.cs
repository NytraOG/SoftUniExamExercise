using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentLibrary
{
    public class LightSoftware : Software
    {
        public LightSoftware(string name, string type, int capacityConsumption, int memoryConsumption)
        {
            this.Name = name;
            this.Type = type;
            this.CapacityConsumption = capacityConsumption + capacityConsumption / 2;
            this.MemoryConsumption = memoryConsumption / 2;
        }
    }
}
