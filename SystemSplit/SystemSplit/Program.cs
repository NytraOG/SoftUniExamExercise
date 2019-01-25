﻿using System;
using System.Collections.Generic;
using ComponentLibrary;
using ComponentLibrary.Hardware;

namespace SystemSplit
{
    class Program
    {
        static void Main(string[] args)
        {
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
