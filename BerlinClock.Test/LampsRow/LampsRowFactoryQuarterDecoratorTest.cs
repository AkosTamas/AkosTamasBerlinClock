using BerlinClock.Domain;
using BerlinClock.LampsRow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BerlinClock.Test.LampsRow
{
    [TestClass]
    public class LampsRowFactoryQuarterDecoratorTest
    {
        [TestMethod]
        public void BuildLampsWithBerlinClockQuarters()
        {
            ILampsRowFactory _sut = new LampsRowFactoryQuarterDecorator();

            var result = _sut.Create(
                6,
                11,
                LampType.SwitchedOnYellow,
                LampType.SwitchedOff);

            Assert.AreEqual("YYRYYROOOOO", result.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DecoratorConstructionWithNullThrowsException()
        {
            var lampsDecorator = new LampsRowFactoryQuarterDecorator(null);
        }
    }
}
