using BerlinClock.Domain;

namespace BerlinClock.Builder
{
    public interface IBerlinClockBuilder
    {
        Lamps BuildIsSecondEven1stRow();
        Lamps BuildHourQuotient2ndRow();
        Lamps BuildHourReminder3rdRow();
        Lamps BuildMinuteQuotient4thRow();
        Lamps BuildMinuteReminder5thRow();
    }
}
