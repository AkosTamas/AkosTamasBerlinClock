using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BerlinClock.Test.Domain
{
    [TestClass]
    public class BerlinClockTest
    {
        [TestMethod]
        public void ToStringOnBerlinClockNullObject()
        {
            var berlinClock = new BerlinClock.Domain.BerlinClock();
            var result = berlinClock.ToString();

            Assert.AreEqual(string.Empty, result);
        }
    }
}
