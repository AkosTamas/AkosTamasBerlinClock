namespace BerlinClock.Domain
{
    public enum LampType
    {
        SwitchedOnRed,
        SwitchedOnYellow,
        SwitchedOff
    }

    /// <summary>
    /// Represents the lamp
    /// </summary>
    public class Lamp
    {
        public string Type { get; }

        public Lamp(LampType lampType)
        {
            if(lampType == LampType.SwitchedOnRed)
            {
                Type = "R";
            }
            if (lampType == LampType.SwitchedOnYellow)
            {
                Type = "Y";
            }
            if (lampType == LampType.SwitchedOff)
            {
                Type = "O";
            }
        }

        public override string ToString()
        {
            return Type;
        }
    }
}
