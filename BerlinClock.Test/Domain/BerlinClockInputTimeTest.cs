using BerlinClock.Domain;
using BerlinClock.InputTime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BerlinClock.Test.Domain
{
    [TestClass]
    public class BerlinClockInputTimeTest
    {
        #region ValidTests

        [TestMethod]
        public void ValidUpperLimitHour()
        {
            var time = new BerlinClockInputTime(24, 00, 00);
        }

        [TestMethod]
        public void ValidLowerLimitHour()
        {
            var time = new BerlinClockInputTime(0, 2, 2);
        }

        [TestMethod]
        public void ValidUpperLimitMinute()
        {
            var time = new BerlinClockInputTime(0, 59, 0);
        }

        [TestMethod]
        public void ValidLowerLimitMinute()
        {
            var time = new BerlinClockInputTime(19, 0, 0);
        }

        [TestMethod]
        public void ValidUpperLimitSecond()
        {
            var time = new BerlinClockInputTime(11, 44, 59);
        }

        [TestMethod]
        public void ValidLowerLimitSecond()
        {
            var time = new BerlinClockInputTime(16, 22, 0);
        }

        #endregion

        #region InvalidTests

        [TestMethod]
        [ExpectedException(typeof(BerlinClockInputTimeException))]
        public void InvalidUpperLimitHourThowsException()
        {
            var time = new BerlinClockInputTime(25, 2, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(BerlinClockInputTimeException))]
        public void InvalidLowerLimitHourThowsException()
        {
            var time = new BerlinClockInputTime(-1, 2, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(BerlinClockInputTimeException))]
        public void InvalidUpperLimitMinuteThowsException()
        {
            var time = new BerlinClockInputTime(0, 60, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(BerlinClockInputTimeException))]
        public void InvalidLowerLimitMinuteThowsException()
        {
            var time = new BerlinClockInputTime(20, -1, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(BerlinClockInputTimeException))]
        public void InvalidUpperLimitSecondThowsException()
        {
            var time = new BerlinClockInputTime(9, 60, 60);
        }

        [TestMethod]
        [ExpectedException(typeof(BerlinClockInputTimeException))]
        public void InvalidLowerLimitSecondThowsException()
        {
            var time = new BerlinClockInputTime(22, 60, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(BerlinClockInputTimeException))]
        public void InvalidTimeThowsException()
        {
            var time = new BerlinClockInputTime(24, 2, 2);
        }

        #endregion
    }
}
