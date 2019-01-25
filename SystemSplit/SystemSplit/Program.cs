using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentLibrary;
using ComponentLibrary.Hardware;

namespace SystemSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * RegisterPowerHardware(SSD,200,300)
RegisterHeavyHardware(HDD,250,500)
RegisterExpressSoftware(Windows10,HDD,150,100)
RegisterExpressSoftware(Linux,SSD,100,300)
RegisterLightSoftware(WinAMP,SSD,50,75)
RegisterLightSoftware(Word,HDD,75,120)
RegisterLightExpressSoftware(Excel,SSD,320,170)
             */
            List<Hardware> system = new List<Hardware>();
            var commandManager = new CommandManager();
            string command;
                
            do
            {
                string commandExpression = null;
                command = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(command))
                {
                    commandExpression = command.Split('(')[0];
                }

                switch (commandExpression)
                {
                    case "RegisterHeavyHardware":
                        commandManager.RegisterHeavyHardware(system, command);
                        break;
                    case "RegisterPowerHardware":
                        commandManager.RegisterPowerHardware(system, command);
                        break;
                    case "RegisterExpressSoftware":
                        commandManager.RegisterExpressSoftware(system, command);
                        break;
                    case "RegisterLightSoftware":
                        commandManager.RegisterLightSoftware(system, command);
                        break;
                    case "ReleaseSoftwareComponent":
                        commandManager.ReleaseSoftwareComponent(system, command);
                        break;
                    case "System split":
                        commandManager.System_Split(system);
                        break;
                    case "Analyze":
                        commandManager.Analyze(system);
                        break;
                }
            } while (command.ToLower() != "system split");
        }
    }
}
