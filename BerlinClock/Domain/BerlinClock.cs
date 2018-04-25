namespace BerlinClock.Domain
{
    /// <summary>
    /// Represents the Berlin Clock with all of its rows.
    /// </summary>
    public class BerlinClock
    {
        public Lamps IsSecondEven1stRow { get; set; }
        public Lamps HourQuotient2ndRow { get; set; }
        public Lamps HourReminder3rdRow { get; set; }
        public Lamps MinuteQuotient4thRow { get; set; }
        public Lamps MinuteReminder5thRow { get; set; }

        public override string ToString()
        {
            string newLine = "\r\n";

            if(IsSecondEven1stRow != null && HourQuotient2ndRow != null 
                && HourReminder3rdRow != null && MinuteQuotient4thRow != null && MinuteReminder5thRow != null)
            {
                return IsSecondEven1stRow.ToString() + newLine +
                    HourQuotient2ndRow.ToString() + newLine +
                    HourReminder3rdRow.ToString() + newLine +
                    MinuteQuotient4thRow.ToString() + newLine +
                    MinuteReminder5thRow.ToString();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
