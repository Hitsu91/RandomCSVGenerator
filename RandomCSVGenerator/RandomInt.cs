using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCSVGenerator
{
    class RandomInt : IRandomObj
    {
        public int Min { get; set; }
        public int Max { get; set; }

        public string Generate()
        {
            return 
                Utilities.random.Next(Min, Max + 1)
                .ToString();
        }
    }
}
