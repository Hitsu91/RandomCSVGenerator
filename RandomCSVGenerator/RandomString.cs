using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCSVGenerator
{
    class RandomString : IRandomObj
    {
        public string[] Strings { get; set; }

        public string Generate()
        {
            return Strings[Utilities.random.Next(Strings.Length)];
        }
    }
}
