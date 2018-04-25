using BerlinClock.InputTime;
using System;

namespace BerlinClock.Domain
{
    /// <summary>
    /// Represents a valid time that can be passed to the Berlin Clock director
    /// </summary>
    public class BerlinClockInputTime
    {
        public int Hour { get; }
        public int Minute { get; }
        public int Second { get; }

        public BerlinClockInputTime(int hour, int minute, int second)
        {
            ValidateTime(hour, minute, second);

            Hour = hour;
            Minute = minute;
            Second = second;
        }

        private void ValidateTime(int hour, int minute, int second)
        {
            if (hour > 24 || hour < 0) // Allow the 00:hh:ss format
            {
                throw new BerlinClockInputTimeException(
                    String.Format(BerlinClockInputTimeExceptionMessages.NotValidHour, hour));
            }

            if (minute > 59 || minute < 0)
            {
                throw new BerlinClockInputTimeException(
                    String.Format(BerlinClockInputTimeExceptionMessages.NotValidMinute, minute));
            }

            if (second > 59 || second < 0)
            {
                throw new BerlinClockInputTimeException(
                    String.Format(BerlinClockInputTimeExceptionMessages.NotValidSecond, second));
            }

            if(hour == 24 && minute != 0 && second != 0)
            {
                throw new BerlinClockInputTimeException(
                    String.Format(BerlinClockInputTimeExceptionMessages.NotValidFormat));
            }
        }
    }
}
