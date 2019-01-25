using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ComponentLibrary;
using ComponentLibrary.Hardware;
using ComponentLibrary.Software;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class CommandManagerTests
    {
        [TestMethod]
        public void CheckingValueExtractionFromGivenCommandString()
        {
            //Arrange
            List<Hardware> system = new List<Hardware>();
            string inputCommand = "RegisterHeavyHardware(SSD, 400, 400)";
            var expectedhardware = new HeavyHardware("SSD", 400, 400);

            //Act
            var commandManager = new CommandManager();
            commandManager.RegisterHeavyHardware(system, inputCommand);

            //Assert
            Assert.AreEqual(system[0].Name, expectedhardware.Name);
            Assert.AreEqual(system[0].MaximumCapacity, expectedhardware.MaximumCapacity);
            Assert.AreEqual(system[0].MaximumMemory, expectedhardware.MaximumMemory);
        }

        [TestMethod]
        public void CheckingValueExtractionForPowerHardware()
        {
            //Arrange
            List<Hardware> theSystem = new List<Hardware>();
            string inputCommand = "RegisterPowerHardware(HDD, 200, 200)";
            var expectedHardware = new PowerHardware("HDD", 200, 200);

            //Act
            var commandManager = new CommandManager();
            commandManager.RegisterPowerHardware(theSystem, inputCommand);

            //Assert
            Assert.AreEqual(theSystem[0].Name, expectedHardware.Name);
            Assert.AreEqual(theSystem[0].MaximumCapacity, expectedHardware.MaximumCapacity);
            Assert.AreEqual(theSystem[0].MaximumMemory, expectedHardware.MaximumMemory);
        }
    }
}
