namespace BerlinClock.InputTime
{
    static internal class BerlinClockInputTimeExceptionMessages
    {
        internal const string InputTimeErrorMessage = 
            "Error occured while parsing input time";

        internal const string NotValidHour =
            "The hour is not valid. Used hour: {0}. Allowed interval: 0-24";

        internal const string NotValidMinute =
            "The minute is not valid. Used minute: {0}. Allowed interval: 0-59";

        internal const string NotValidSecond =
            "The second is not valid. Used second: {0}. Allowed interval: 0-59";

        internal const string NotValidFormat =
            "Time has an invalid format.";
    }
}
