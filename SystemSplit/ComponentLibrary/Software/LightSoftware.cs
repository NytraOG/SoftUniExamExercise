namespace ComponentLibrary.Software
{
    public class LightSoftware : Software
    {
        private string type;

        public LightSoftware(string name, int capacityConsumption, int memoryConsumption) : base(name, capacityConsumption, memoryConsumption)
        {
            this.CapacityConsumption = capacityConsumption;
            this.MemoryConsumption = memoryConsumption;
            this.type = "Light";
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
