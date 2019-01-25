namespace ComponentLibrary.Software
{
    public class Software
    {
        private string name;
        private string type;
        private string nameHardware;
        private int capacityConsumption;
        private int memoryConsumption;

        protected Software(string name, string nameHardware, int capacityConsumption, int memoryConsumption)
        {
            this.Name = name;
            this.NameHardware = nameHardware;
            this.CapacityConsumption = capacityConsumption;
            this.MemoryConsumption = memoryConsumption;
        }
        
        public string Name { get; private set; }
        public string Type { get; protected set; }
        public string NameHardware { get; set; }
        public virtual int CapacityConsumption { get; protected set; }
        public virtual int MemoryConsumption { get; protected set; }
    }
}
