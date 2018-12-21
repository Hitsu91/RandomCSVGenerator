using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Randomizer
    {
        private List<object> elements;
        private Random random;

        public Randomizer()
        {
            elements = new List<Object>();
            random = new Random();
        }

        public void AddElement(object element)
        {
            elements.Add(element);
        }

        public void ReadFromFile(string path)
        {
            AddElement(File.ReadAllLines(path));
        }

        public void AddNumberRange(double min, double max)
        {
            AddElement(new double[] { min, max });
        }

        public void AddNumberRange(int min, int max)
        {
            AddElement(new int[] { min, max });
        }

        public string ToCSV()
        {
            string[] res = new string[elements.Count];

            for (int i = 0; i < res.Length; i++)
                res[i] += PickRandom(elements[i]);

            return String.Join(",", res);
        }

        public string ToCSV(int lines)
        {
            string res = "";
            for (int i = 0; i < lines; i++)
                res += ToCSV() + "\r\n";

            return res;
        }

        private string PickRandom(object o)
        {
            String res = "";

            if (o is string[] strings)
                res = strings[random.Next(strings.Length)];
            else if (o is double[] doubles)
                res = Math.Round(random.NextDouble() * (doubles[0] - doubles[1]) + doubles[1], 2).ToString().Replace(",", ".");
            else if (o is int[] integers)
                res = random.Next(integers[0], integers[1]).ToString();


            return res;
        }


    }
}
