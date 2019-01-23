namespace ComponentLibrary.Software
{
    public class ExpressSoftware : Software
    {
        private string type;

        public ExpressSoftware(string name, int capacityConsumption, int memoryConsumption) : base(name, capacityConsumption, memoryConsumption)
        {
            this.MemoryConsumption = memoryConsumption;
            this.type = "Express";
        }
        
        public override int MemoryConsumption
        {
            get => base.MemoryConsumption;
            protected set => base.MemoryConsumption = value * 2;
        }
    }
}
