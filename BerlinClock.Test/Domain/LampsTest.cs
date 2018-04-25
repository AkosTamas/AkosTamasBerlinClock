using System;
using System.Collections.Generic;
using BerlinClock.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BerlinClock.Test.Domain
{
    [TestClass]
    public class LampsTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LampsConstructorNullParameterThrowsException()
        {
            var lamp = new Lamps(null);
        }

        [TestMethod]
        public void LampsEmptyListToString()
        {
            var lamps = new Lamps(new List<Lamp>());
            var result = lamps.ToString();

            Assert.AreEqual(string.Empty, result);
        }
    }
}
