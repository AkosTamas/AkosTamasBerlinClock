using BerlinClock.Domain;
using System;
using System.Globalization;

namespace BerlinClock.InputTime
{
    /// <summary>
    /// Responsible for parse the input time
    /// </summary>
    public class BerlinClockDateTimeParser : IBerlinClockInputTimeParser
    {
        /// <summary>
        /// Parse the time. Expected time is in HH:mm:ss format. Using 24:00:00 as midnight time is also allowed."
        /// </summary>
        /// <exception cref="BerlinClock.InputTime.BerlinClockInputTimeException"></exception>
        public BerlinClockInputTime Parse(string time)
        {
            try
            {
                // The DateTime.ParseExact throws a FormatException in the case of 00:00:00 but Berlin Clock allows it
                if (time == "24:00:00")
                {
                    return new BerlinClockInputTime(24, 0, 0);
                }
                else
                {
                    var dateTime = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture);
                    return new BerlinClockInputTime(dateTime.Hour, dateTime.Minute, dateTime.Second);
                }
            }
            catch (ArgumentNullException e)
            {
                throw new BerlinClockInputTimeException(
                    BerlinClockInputTimeExceptionMessages.InputTimeErrorMessage, 
                    e);
            }
            catch (FormatException e)
            {
                throw new BerlinClockInputTimeException(
                    BerlinClockInputTimeExceptionMessages.InputTimeErrorMessage,
                    e);
            }
        }
    }
}
