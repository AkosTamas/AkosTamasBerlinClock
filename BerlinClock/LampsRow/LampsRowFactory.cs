using BerlinClock.Domain;
using System;
using System.Collections.Generic;

namespace BerlinClock.LampsRow
{
    /// <summary>
    /// This class creates the Lamps object that represents the lamps in a row
    /// </summary>
    public class LampsRowFactory : ILampsRowFactory
    {
        public Lamps Create(
            int numberOfSwitchedOnLamps,
            int numberOfLamps,
            LampType switchedOnLamp,
            LampType switchedOffLamp)
        {
            #region ValidateInput

            int minimumNumberOfLamps = 0;

            if (numberOfSwitchedOnLamps < minimumNumberOfLamps)
            {
                throw new ArgumentException(nameof(numberOfSwitchedOnLamps));
            }

            if (numberOfLamps < minimumNumberOfLamps)
            {
                throw new ArgumentException(nameof(numberOfSwitchedOnLamps));
            }

            #endregion

            List<Lamp> lamps = new List<Lamp>();
            for (int i = 0; i < numberOfSwitchedOnLamps; i++)
            {
                lamps.Add(new Lamp(switchedOnLamp));
            }

            for (int i = numberOfSwitchedOnLamps; i < numberOfLamps; i++)
            {
                lamps.Add(new Lamp(switchedOffLamp));
            }

            return new Lamps(lamps);
        }
    }
}
