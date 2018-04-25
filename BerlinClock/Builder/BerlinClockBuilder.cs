using BerlinClock.Domain;
using BerlinClock.LampsRow;
using System;

namespace BerlinClock.Builder
{
    /// <summary>
    /// Builder class. It is responsible for build every rows (containing the lamps) of the Berlin Clock.
    /// </summary>
    public class BerlinClockBuilder : IBerlinClockBuilder
    {
        private readonly int _modulo = 5;
        private readonly BerlinClockInputTime _time;
        private readonly ILampsRowFactory _factory;
        private readonly ILampsRowFactory _decorator;

        public BerlinClockBuilder(BerlinClockInputTime time) : 
            this(time, new LampsRowFactory(), new LampsRowFactoryQuarterDecorator())
        {
        }

        public BerlinClockBuilder(BerlinClockInputTime time, ILampsRowFactory factory, ILampsRowFactory decorator)
        {
            _time = time ?? throw new ArgumentNullException(nameof(time));
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            _decorator = decorator ?? throw new ArgumentNullException(nameof(decorator));
        }

        public Lamps BuildIsSecondEven1stRow()
        {
            var lampType = (_time.Second % 2 == 0) ? LampType.SwitchedOnYellow : LampType.SwitchedOff;

            return _factory.Create(1, 1, lampType, LampType.SwitchedOff);
        }

        public Lamps BuildHourQuotient2ndRow()
        {
            int hourQuotient = _time.Hour / _modulo;

            return _factory.Create(hourQuotient, 4, LampType.SwitchedOnRed, LampType.SwitchedOff);
        }

        public Lamps BuildHourReminder3rdRow()
        {
            int hourReminder = _time.Hour % _modulo;

            return _factory.Create(hourReminder, 4, LampType.SwitchedOnRed, LampType.SwitchedOff);
        }

        public Lamps BuildMinuteQuotient4thRow()
        {
            int minuteQuotient = _time.Minute / _modulo;

            return _decorator.Create(minuteQuotient, 11, LampType.SwitchedOnYellow, LampType.SwitchedOff);
        }

        public Lamps BuildMinuteReminder5thRow()
        {
            int minuteReminder = _time.Minute % _modulo;

            return _factory.Create(minuteReminder, 4, LampType.SwitchedOnYellow, LampType.SwitchedOff);
        }
    }
}
