using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentLibrary
{
    public class ComponentManager
    {
        public void RegisterHeavyHardware(string name, int capacity, int memory)
        {
            var heavyHardware = new HeavyHardware(name, capacity, memory);
        }

        public void RegisterPowerHardware(string name, int capacity, int memory)
        {
            var powerHardware = new PowerHardware(name, capacity, memory);
        }

        public void RegisterExpressSoftware(string name, int capacityConsumption, int memoryConsumption)
        {

        }

        public void RegisterLightSoftware(string name, int capacityConsumption, int memoryConsumption)
        {

        }

        public void ReleaseSoftwareComponent()
        {

        }

        public void Analyze()
        {

        }

        public void SystemSplit()
        {

        }
    }
}
