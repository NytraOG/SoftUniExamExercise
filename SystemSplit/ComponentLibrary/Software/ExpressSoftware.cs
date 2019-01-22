using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentLibrary
{
    public class ExpressSoftware : Software
    {
        public ExpressSoftware(string name, int capacityConsumption, int memoryConsumption)
        {
            this.Name = name;
            this.Type = "Express";
            this.CapacityConsumption = capacityConsumption;
            this.MemoryConsumption = memoryConsumption * 2;
        }
    }
}
