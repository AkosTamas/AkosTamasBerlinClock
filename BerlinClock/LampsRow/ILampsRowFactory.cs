using BerlinClock.Domain;

namespace BerlinClock.LampsRow
{
    public interface ILampsRowFactory
    {
        Lamps Create(
            int numberOfSwitchedOnLamps,
            int numberOfLamps,
            LampType switchedOnLamp,
            LampType switchedOffLamp);
    }
}
