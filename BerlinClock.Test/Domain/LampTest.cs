using BerlinClock.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BerlinClock.Test.Domain
{
    [TestClass]
    public class LampTest
    {
        [TestMethod]
        public void LampTypeRed()
        {
            var lamp = new Lamp(LampType.SwitchedOnRed);
            string result = lamp.ToString();

            Assert.AreEqual("R", result);
        }

        [TestMethod]
        public void LampTypeYellow()
        {
            var lamp = new Lamp(LampType.SwitchedOnYellow);
            string result = lamp.ToString();

            Assert.AreEqual("Y", result);
        }

        [TestMethod]
        public void LampTypeOff()
        {
            var lamp = new Lamp(LampType.SwitchedOff);
            string result = lamp.ToString();

            Assert.AreEqual("O", result);
        }
    }
}
