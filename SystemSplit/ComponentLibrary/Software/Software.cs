using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentLibrary
{
    public class Software
    {
        private string name;
        private string type;
        private int capacityConsumption;
        private int memoryConsumption;

        public string Name { get; set; }
        public string Type { get; set; }
        public int CapacityConsumption { get; set; }
        public int MemoryConsumption { get; set; }

        public override string ToString()
        {
            return $"Name: {name}, Type: {type}, Capacity: {capacityConsumption}, Memory: {memoryConsumption}";
        }
    }
}
