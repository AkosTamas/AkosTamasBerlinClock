using BerlinClock.Builder;
using BerlinClock.Director;
using BerlinClock.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace BerlinClock.Test.Director
{
    [TestClass]
    public class BerlinClockDirectorTest
    {
        [TestMethod]
        public void DirectorValidContsruct()
        {
            var time = new BerlinClockInputTime(23, 11, 44);
            var mock = new Mock<IBerlinClockBuilder>();

            var sut = new BerlinClockDirector(mock.Object);
            sut.Construct();

            mock.Verify(x => x.BuildIsSecondEven1stRow(), Times.Once);
            mock.Verify(x => x.BuildHourQuotient2ndRow(), Times.Once);
            mock.Verify(x => x.BuildHourReminder3rdRow(), Times.Once);
            mock.Verify(x => x.BuildMinuteQuotient4thRow(), Times.Once);
            mock.Verify(x => x.BuildMinuteReminder5thRow(), Times.Once);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DirectorContructionWithNullBuilderThrowsException()
        {
            IBerlinClockBuilder builder = null;
            var director = new BerlinClockDirector(builder);
        }
    }
}
