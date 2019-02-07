using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCSVGenerator
{
    class RandomDate : IRandomObj
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public string Generate()
        {
            int range = (End - Start).Days;
            return Start.AddDays(Utilities.random.Next(range + 1)).ToString(Randomizer.DefaultDateFormat);
        }

        public void Reset()
        {
            
        }
    }
}
