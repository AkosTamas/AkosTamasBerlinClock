using System;

namespace BerlinClock.InputTime
{
    /// <summary>
    /// Represents errors that occur when process the input time 
    /// </summary>
    public class BerlinClockInputTimeException : Exception
    {
        public BerlinClockInputTimeException(string errorMessage) :
            base(errorMessage)
        {
        }

        public BerlinClockInputTimeException(string errorMessage, Exception innerException) :
            base(errorMessage, innerException)
        {
        }
    }
}
