using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCSVGenerator
{
    class IdGenerator : IRandomObj
    {
        private int id = 0;

        public string Generate()
        {
            return (++id).ToString();
        }

        public void Reset()
        {
            id = 0;
        }
    }
}
