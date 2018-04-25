using BerlinClock.Director;
using BerlinClock.InputTime;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        public string ConvertTime(string time)
        {
            IBerlinClockInputTimeParser parser = new BerlinClockDateTimeParser();
            var parsedTime = parser.Parse(time); 

            IBerlinClockDirector director = new BerlinClockDirector(parsedTime);
            var berlinClock = director.Construct();

            return (berlinClock == null) ? string.Empty : berlinClock.ToString(); 
        }
    }
}
