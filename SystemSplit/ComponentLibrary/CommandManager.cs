using System;
using System.Collections.Generic;
using System.Linq;
using ComponentLibrary.Hardware;
using ComponentLibrary.Software;

namespace ComponentLibrary
{
    public class CommandManager
    {
        public void RegisterHeavyHardware(List<Hardware.Hardware> theSystem, string command)
        {
            var zwischenspeicher = command.Split('(');
            var zwischenspeicher2 = zwischenspeicher[1].Substring(0, zwischenspeicher[1].Length - 1);
            var splitArray = zwischenspeicher2.Split(',').Select(s => s.Trim()).ToArray();

            var name = splitArray[0];
            int capacity = Convert.ToInt32(splitArray[1]);
            int memory = Convert.ToInt32(splitArray[2]);
            theSystem.Add(new HeavyHardware(name, capacity, memory));
        }

        public void RegisterPowerHardware(List<Hardware.Hardware> theSystem, string command)
        {
            var zwischenspeicher = command.Split('(');
            var zwischenspeicher2 = zwischenspeicher[1].Substring(0, zwischenspeicher[1].Length - 1);
            var splitArray = zwischenspeicher2.Split(',').Select(s => s.Trim()).ToArray();

            var name = splitArray[0];
            var capacity = Convert.ToInt32(splitArray[1]);
            var memorty = Convert.ToInt32(splitArray[2]);
            theSystem.Add(new PowerHardware(name, capacity, memorty));
        }

        public void RegisterExpressSoftware(List<Hardware.Hardware> theSystem, string command)
        {
            var zwischenspeicher = command.Split('(');
            var zwischenspeicher2 = zwischenspeicher[1].Substring(0, zwischenspeicher[1].Length - 1);
            var splitArray = zwischenspeicher2.Split(',').Select(s => s.Trim()).ToArray();

            var name = splitArray[0];
            var nameHardware = splitArray[1];
            var capacity = Convert.ToInt32(splitArray[2]);
            var memory = Convert.ToInt32(splitArray[3]);

            if (theSystem.Any(h => h.Name == nameHardware))
            {
                var hardware = theSystem.First(h => h.Name == nameHardware);

                if (hardware.MaximumCapacity - hardware.UsedCapacity >= capacity && hardware.MaximumMemory - hardware.UsedMemory >= memory)
                {
                    var software = new ExpressSoftware(name, nameHardware, capacity, memory);

                    hardware.ListOfInstalledSoftware.Add(software);
                    hardware.UsedCapacity += software.CapacityConsumption;
                    hardware.UsedMemory += software.MemoryConsumption;
                }
            }
        }

        public void RegisterLightSoftware(List<Hardware.Hardware> system, string command)
        {
            var zwischenspeicher = command.Split('(');
            var zwischenspeicher2 = zwischenspeicher[1].Substring(0, zwischenspeicher[1].Length - 1);
            var splitArray = zwischenspeicher2.Split(',').ToArray();

            var name = splitArray[0];
            var nameHardware = splitArray[1];
            var capacity = Convert.ToInt32(splitArray[2]);
            var memory = Convert.ToInt32(splitArray[3]);

            if (system.Any(s => s.Name == nameHardware))
            {
                var hardware = system.First(s => s.Name == nameHardware);

                if (hardware.MaximumCapacity - hardware.UsedCapacity >= capacity && hardware.MaximumMemory - hardware.UsedMemory >= memory)
                {
                    var software = new LightSoftware(name, nameHardware, capacity, memory);

                    hardware.RegisterSoftwareComponent(software);
                    hardware.UsedCapacity += software.CapacityConsumption;
                    hardware.UsedMemory += software.MemoryConsumption;
                }
            }
        }

        public void ReleaseSoftwareComponent(List<Hardware.Hardware> system, string command)
        {
            var zwischenspeicher = command.Split('(');
            var zwischenspeicher2 = zwischenspeicher[1].Substring(0, zwischenspeicher[1].Length - 1);
            var nameArray = zwischenspeicher2.Split(',').Select(x => x.Trim()).ToArray();

            var hardwareName = nameArray[0];
            var softwareName = nameArray[1];

            if (system.Any(x => x.Name == hardwareName))
            {
                var hardware = system.First(x => x.Name == hardwareName);

                if (hardware.GetListOfSoftware().Any(x => x.Name == softwareName))
                {
                    var software = hardware.ListOfInstalledSoftware.First(x => x.Name == softwareName);

                    hardware.UsedCapacity -= software.CapacityConsumption;
                    hardware.UsedMemory -= software.MemoryConsumption;
                    hardware.RemoveSoftwareComponent(software);
                }
            }
        }

        public void Analyze(List<Hardware.Hardware> system)
        {
            Console.WriteLine($"  \tSystem Analysis:" +
                              $"\n\tHardware Components: {system.Count}" +
                              $"\n\tSoftware Components: {system.Sum(x => x.GetListOfSoftware().Count)}" +
                              $"\n\tTotal Operational Memory: {system.Sum(x => x.UsedMemory)} / {system.Sum(x => x.MaximumMemory)}" +
                              $"\n\tTotal Capacity taken: {system.Sum(x => x.UsedCapacity)} / {system.Sum(x => x.MaximumCapacity)}");
        }

        public void System_Split(List<Hardware.Hardware> system)
        {
            string installedSoftware = "";
            Console.WriteLine($"  \tFinal System Analysis:");

            foreach (var hardware in system)
            {
                foreach (var software in hardware.GetListOfSoftware())
                {
                    installedSoftware += $"{software.Name}, ";
                }


                Console.WriteLine($"\n\tHardware Component: {hardware.Name}" +
                                  $"\n\tHardware Type: {hardware.Type}" +
                                  $"\n\tInstalled Express Software: {hardware.GetListOfSoftware().Count(x => x.Type == "Express")}" +
                                  $"\n\tInstalled Light Software: {hardware.GetListOfSoftware().Count(x => x.Type == "Light")}" +
                                  $"\n\tMemory Usage: {hardware.UsedMemory} / {hardware.MaximumMemory}" +
                                  $"\n\tCapacity Usage: {hardware.UsedCapacity} / {hardware.MaximumCapacity}7" +
                                  $"\n\tSoftware Components: {installedSoftware}\n\n");

                installedSoftware = "";
            }
        }
    }
}
