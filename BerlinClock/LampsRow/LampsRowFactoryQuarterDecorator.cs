using BerlinClock.Domain;
using System;
using System.Collections.Generic;

namespace BerlinClock.LampsRow
{
    /// <summary>
    /// It is a decorator class that extends the lamps row. It changes the lamps at the quarters.
    /// </summary>
    public class LampsRowFactoryQuarterDecorator : ILampsRowFactory
    {
        private readonly List<int> _quarters = new List<int>() { 3, 6, 9 };
        private readonly ILampsRowFactory _factory;

        public LampsRowFactoryQuarterDecorator() : this(new LampsRowFactory()) { }

        public LampsRowFactoryQuarterDecorator(ILampsRowFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        public Lamps Create(
            int numberOfSwitchedOnLamps, 
            int numberOfLamps,
            LampType switchedOnLamp,
            LampType switchedOffLamp)
        {
            var lampsRow = _factory.Create(
                numberOfSwitchedOnLamps,
                numberOfLamps, 
                switchedOnLamp,
                switchedOffLamp);

            ModifyLampstAtQuarters(lampsRow, numberOfSwitchedOnLamps);

            return lampsRow;
        }

        private void ModifyLampstAtQuarters(Lamps lamps, int numberOfSwitchedOnLamps)
        {
            if(lamps != null)
            {
                foreach (var quarter in _quarters)
                {
                    if (numberOfSwitchedOnLamps >= quarter)
                    {
                        lamps.LampItems[quarter - 1] = new Lamp(LampType.SwitchedOnRed);
                    }
                }
            }
        }
    }
}
