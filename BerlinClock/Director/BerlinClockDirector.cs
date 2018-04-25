using BerlinClock.Builder;
using BerlinClock.Domain;
using System;

namespace BerlinClock.Director
{
    /// <summary>
    /// Director class. It is responsible for the contruction logic of the Berlin Clock object.
    /// </summary>
    public class BerlinClockDirector : IBerlinClockDirector
    {
        private readonly IBerlinClockBuilder _builder;

        public BerlinClockDirector(BerlinClockInputTime time) 
            : this(new BerlinClockBuilder(time)) { }

        public BerlinClockDirector(IBerlinClockBuilder builder)
        {
            _builder = builder ?? throw new ArgumentNullException(nameof(builder));
        }

        public Domain.BerlinClock Construct()
        {
            return new Domain.BerlinClock
            {
                IsSecondEven1stRow = _builder.BuildIsSecondEven1stRow(),
                HourQuotient2ndRow = _builder.BuildHourQuotient2ndRow(),
                HourReminder3rdRow = _builder.BuildHourReminder3rdRow(),
                MinuteQuotient4thRow = _builder.BuildMinuteQuotient4thRow(),
                MinuteReminder5thRow = _builder.BuildMinuteReminder5thRow()
            };
        }
    }
}
