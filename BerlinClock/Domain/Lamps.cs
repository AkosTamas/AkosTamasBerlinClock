using System;
using System.Collections.Generic;
using System.Text;

namespace BerlinClock.Domain
{
    /// <summary>
    /// Represents the lamps in a row
    /// </summary>
    public class Lamps
    {
        private readonly List<Lamp> _lampItems = new List<Lamp>();

        public List<Lamp> LampItems => _lampItems;

        public Lamps(List<Lamp> lamps)
        {
            _lampItems = lamps ?? throw new ArgumentNullException(nameof(lamps));
        }

        public override string ToString()
        {
            var str = new StringBuilder(_lampItems.Count);

            foreach (var lamp in LampItems)
            {
                str.Append(lamp);
            }

            return str.ToString();
        }
    }
}
