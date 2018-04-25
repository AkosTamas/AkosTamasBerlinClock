using BerlinClock.InputTime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BerlinClock.Test.InputTime
{
    [TestClass]
    public class BerlinClockDateTimeParserTest
    {
        private readonly IBerlinClockInputTimeParser _parser;
        
        public BerlinClockDateTimeParserTest()
        {
            _parser = new BerlinClockDateTimeParser();
        }
        
        [TestMethod]
        public void ParseValidTime()
        {
            var time = "11:12:00";
            var result = _parser.Parse(time);

            Assert.AreEqual(11, result.Hour);
            Assert.AreEqual(12, result.Minute);
            Assert.AreEqual(0, result.Second);
        }

        [TestMethod]
        [ExpectedException(typeof(BerlinClockInputTimeException))]
        public void ParseInValidFormatTimeThrowsException()
        {
            var time = "11:12:00 PM";
            _parser.Parse(time);
        }

        [TestMethod]
        [ExpectedException(typeof(BerlinClockInputTimeException))]
        public void ParseNullTimeThrowsException()
        {
            _parser.Parse(null);
        }
    }
}
