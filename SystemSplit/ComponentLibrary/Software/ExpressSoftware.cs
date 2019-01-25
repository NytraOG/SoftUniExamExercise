namespace ComponentLibrary.Software
{
    public class ExpressSoftware : Software
    {
        public ExpressSoftware(string name, string nameHardware, int capacityConsumption, int memoryConsumption) 
            : base(name, nameHardware, capacityConsumption, memoryConsumption)
        {
            this.MemoryConsumption = memoryConsumption;
            this.Type = "Express";
        }

        public override int MemoryConsumption
        {
            get => base.MemoryConsumption;
            protected set => base.MemoryConsumption = value * 2;
        }
    }
}
