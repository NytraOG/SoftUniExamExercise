using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentLibrary;
using ComponentLibrary.Hardware;
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
            List<Hardware> theSystem = new List<Hardware>();
            string inputCommand = "RegisterHeavyHardware(SSD, 400, 400)";
            var expectedhardware = new HeavyHardware("SSD", 400, 400);

            //Act
            var commandManager = new CommandManager();
            commandManager.RegisterHeavyHardware(theSystem, inputCommand);

            //Assert
            Assert.AreEqual(theSystem[0], expectedhardware);
        }
    }
}
