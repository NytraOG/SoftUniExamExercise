using System.Collections.Generic;

namespace ComponentLibrary.Hardware
{
    public class Hardware
    {
        private string name;
        private int maximumCapacity;
        private int maximumMemory;
        private int usedCapacity;
        private int usedMemory;
        private List<Software.Software> listOfInstalledSoftware;

        protected Hardware(string name, int maximumCapacity, int maximumMemory)
        {
            Name = name;
            MaximumCapacity = maximumCapacity;
            MaximumMemory = maximumMemory;
            UsedCapacity = 0;
            UsedMemory = 0;
            ListOfInstalledSoftware = new List<Software.Software>();
        }

        public string Name { get; private set; }
        public virtual int MaximumCapacity { get; protected set; }
        public virtual int MaximumMemory { get; protected set; }
        public int UsedCapacity { get; set; }
        public int UsedMemory { get; set; }
        public List<Software.Software> ListOfInstalledSoftware { get; set; }

        public void RegisterSoftwareComponent(Software.Software software)
        {
            ListOfInstalledSoftware.Add(software);
        }

        public void RemoveSoftwareComponent(Software.Software software)
        {
            ListOfInstalledSoftware.Remove(software);
        }

        public List<Software.Software> GetListOfSoftware()
        {
            return ListOfInstalledSoftware;
        }
    }
}
