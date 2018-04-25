using BerlinClock.Domain;

namespace BerlinClock.InputTime
{
    public interface IBerlinClockInputTimeParser
    {
        BerlinClockInputTime Parse(string time);
    }
}
