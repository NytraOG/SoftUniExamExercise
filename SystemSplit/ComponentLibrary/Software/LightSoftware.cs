namespace ComponentLibrary.Software
{
    public class LightSoftware : Software
    {
        public LightSoftware(string name, string nameHardware, int capacityConsumption, int memoryConsumption) : base(name, nameHardware, capacityConsumption, memoryConsumption)
        {
            this.CapacityConsumption = capacityConsumption;
            this.MemoryConsumption = memoryConsumption;
            this.Type = "Light";
        }

        public override int CapacityConsumption
        {
            get => base.CapacityConsumption;
            protected set => base.CapacityConsumption = value * 3 / 2;
        }

        public override int MemoryConsumption
        {
            get => base.MemoryConsumption;
            protected set => base.MemoryConsumption = value / 2;
        }
    }
}
