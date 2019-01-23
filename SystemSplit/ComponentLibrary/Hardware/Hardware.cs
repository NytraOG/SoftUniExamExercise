using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentLibrary
{
    public class Hardware
    {
        private string name;
        private int maximumCapacity;
        private int maximumMemory;
        private int usedCapacity;
        private int usedMemory;
        private List<Software> listOfInstalledSoftware;

        protected Hardware(string name, int maximumCapacity, int maximumMemory)
        {
            Name = name;
            MaximumCapacity = maximumCapacity;
            MaximumMemory = maximumMemory;
            UsedCapacity = 0;
            UsedMemory = 0;
            ListOfInstalledSoftware = new List<Software>();
        }

        public string Name { get; private set; }
        public virtual int MaximumCapacity { get; protected set; }
        public virtual int MaximumMemory { get; protected set; }
        public int UsedCapacity { get; set; }
        public int UsedMemory { get; set; }
        public List<Software> ListOfInstalledSoftware { get; set; }

        public void RegisterSoftwareComponent(Software software)
        {
            ListOfInstalledSoftware.Add(software);
        }

        public void RemoveSoftwareComponent(Software software)
        {
            ListOfInstalledSoftware.Remove(software);
        }

        public List<Software> GetListOfSoftware()
        {
            return ListOfInstalledSoftware;
        }
    }
}
