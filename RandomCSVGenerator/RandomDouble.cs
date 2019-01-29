using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCSVGenerator
{
    class RandomDouble : IRandomObj
    {
        public double Min { get; set; }
        public double Max { get; set; }

        public string Generate()
        {
            return 
                Math.Round(Utilities.random.NextDouble() * (Max - Min) + Min, 2)
                .ToString().Replace(",", ".");
        }
    }
}
