using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentLibrary
{
    public class HeavyHardware : Hardware
    {
        public HeavyHardware(string name, string type, int maximumCapacity, int maximumMemory)
        {
            this.Name = name;
            this.Type = type;
            this.MaximumCapacity = maximumCapacity * 2;
            this.MaximumMemory = maximumMemory * 3 / 4;
        }
    }
}
