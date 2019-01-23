namespace ComponentLibrary.Hardware
{
    public class PowerHardware : Hardware
    {
        private string type;

        public PowerHardware(string name, int maximumCapacity, int maximumMemory) : base(name, maximumCapacity, maximumMemory)
        {
            this.MaximumCapacity = maximumCapacity;
            this.MaximumMemory = maximumMemory;
            this.type = "Power";
        }

        public override int MaximumCapacity
        {
            get => base.MaximumCapacity;
            protected set => base.MaximumCapacity = value / 4;
        }

        public override int MaximumMemory
        {
            get => base.MaximumMemory;
            protected set => base.MaximumMemory = value * 7 / 4;
        }
    }
}
