using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCSVGenerator
{
    class VectorElement : IRandomObj
    {
        private static Random rd = new Random();

        public string Delimiter { get; set; } = "-";
        public int MaxRepeater { get; set; } = 5;
        public List<string> Elements = new List<string>();

        public string Generate()
        {
            int repeat = rd.Next(MaxRepeater) + 1;
            string[] results = new string[repeat];

            for (int i = 0; i < repeat; i++)
                results[i] = Elements[rd.Next(Elements.Count)];

            return String.Join(Delimiter, results);
        }
    }
}
