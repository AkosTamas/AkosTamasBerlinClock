using BerlinClock.Domain;
using BerlinClock.LampsRow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BerlinClock.Test.LampsRow
{
    [TestClass]
    public class LampsRowFactoryTest
    {
        private readonly ILampsRowFactory _sut;

        public LampsRowFactoryTest()
        {
            _sut = new LampsRowFactory();
        }

        [TestMethod]
        public void CreateRedLamps()
        {
            var result = _sut.Create(
                2, 
                4,
                LampType.SwitchedOnRed,
                LampType.SwitchedOff);

            Assert.AreEqual("RROO", result.ToString());
        }

        [TestMethod]
        public void CreateYellowLamps()
        {
            var result = _sut.Create(
                8,
                11,
                LampType.SwitchedOnYellow,
                LampType.SwitchedOff);

            Assert.AreEqual("YYYYYYYYOOO", result.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateInvalidSwitchedOnLampsThrowsException()
        {
            var result = _sut.Create(
                -1,
                11,
                LampType.SwitchedOnYellow,
                LampType.SwitchedOff);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateInvalidNumberOfLampsThrowsException()
        {
            var result = _sut.Create(
                2,
                -1,
                LampType.SwitchedOnYellow,
                LampType.SwitchedOff);
        }
    }
}
