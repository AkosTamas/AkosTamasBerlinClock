using BerlinClock.Builder;
using BerlinClock.Domain;
using BerlinClock.LampsRow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace BerlinClock.Test.Builder
{
    [TestClass]
    public class BerlinClockBuilderTest
    {
        private readonly BerlinClockInputTime _time;
        private readonly Mock<ILampsRowFactory> _mock;
        private readonly BerlinClockBuilder _sut;

        public BerlinClockBuilderTest()
        {
            _time = new BerlinClockInputTime(21, 11, 10);
            _mock = new Mock<ILampsRowFactory>();

            _sut = new BerlinClockBuilder(_time, _mock.Object, _mock.Object);
        }

        [TestMethod]
        public void BuildIsSecondEven1stRow()
        {
            _sut.BuildIsSecondEven1stRow();

            _mock.Verify(x => x.Create(1, 1, LampType.SwitchedOnYellow, LampType.SwitchedOff), Times.Once);
        }

        [TestMethod]
        public void BuildHourQuotient2ndRow()
        {

            _sut.BuildHourQuotient2ndRow();

            _mock.Verify(x => x.Create(4, 4, LampType.SwitchedOnRed, LampType.SwitchedOff), Times.Once);
        }

        [TestMethod]
        public void BuildHourReminder3rdRow()
        {

            _sut.BuildHourReminder3rdRow();

            _mock.Verify(x => x.Create(1, 4, LampType.SwitchedOnRed, LampType.SwitchedOff), Times.Once);
        }

        [TestMethod]
        public void BuildMinuteQuotient4thRow()
        {

            _sut.BuildMinuteQuotient4thRow();

            _mock.Verify(x => x.Create(2, 11, LampType.SwitchedOnYellow, LampType.SwitchedOff), Times.Once);
        }

        [TestMethod]
        public void BuildMinuteReminder5thRow()
        {

            _sut.BuildMinuteReminder5thRow();

            _mock.Verify(x => x.Create(1, 4, LampType.SwitchedOnYellow, LampType.SwitchedOff), Times.Once);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void BuilderConstructionWithNullTimeThrowsexception()
        {
            var sut = new BerlinClockBuilder(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void BuilderConstructionWithNullFactoryThrowsexception()
        {
            var sut = new BerlinClockBuilder(_time, null, _mock.Object);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void BuilderConstructionWithOtherNullFactoryThrowsexception()
        {
            var sut = new BerlinClockBuilder(_time, _mock.Object, null);
        }
    }
}
