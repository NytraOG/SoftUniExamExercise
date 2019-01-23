using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentLibrary
{
    public class HeavyHardware : Hardware
    {
        private string type;

        public HeavyHardware(string name, int maximumCapacity, int maximumMemory) : base(name, maximumCapacity, maximumMemory)
        {
            this.MaximumCapacity = maximumCapacity;
            this.MaximumMemory = maximumMemory;
            this.type = "Heavy";
        }

        public override int MaximumCapacity
        {
            get => base.MaximumCapacity;
            protected set => base.MaximumCapacity = value * 2;
        }

        public override int MaximumMemory
        {
            get => base.MaximumMemory;
            protected set => base.MaximumMemory = value * 3 / 4;
        }
    }
}
