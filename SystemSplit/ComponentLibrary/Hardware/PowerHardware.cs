﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentLibrary
{
    public class PowerHardware : Hardware
    {
        public PowerHardware(string name, int maximumCapacity, int maximumMemory)
        {
            this.Name = name;
            this.Type = "Power";
            this.MaximumCapacity = maximumCapacity / 4;
            this.MaximumMemory = maximumMemory + maximumMemory * 3 / 4;
        }
    }
}