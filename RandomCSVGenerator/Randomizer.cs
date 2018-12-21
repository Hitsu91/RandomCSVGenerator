using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCSVGenerator
{
    class Randomizer
    {
        private static readonly Dictionary<String, String> paths =
            new Dictionary<string, string>()
            {
                { "names", "../../resources/names.txt" },
                { "cities","../../resources/cities.txt" }
            };

        public static readonly List<String> dateFormats =
            new List<string>()
            {
                "yyyy-MM-dd" ,
                "dd/MM/yyyy"
            };

        public static readonly Dictionary<string, string> Separators = new Dictionary<string, string>()
        {
            {"Comma [,]", "," },
            {"Semicolon [;]", ";" }
        };

        public static readonly string vectorFileSuggestion = "The file must have first line the delimiter char and at second line the number of max repeat";

        private List<object> elements;
        private Random random;
        private string[] nameList;
        private string[] cityList;
        public string DefaultSeparator { get; set; } = ",";
        public string DefaultDateFormat { get; set; } = dateFormats[0];

        public Randomizer()
        {
            elements = new List<Object>();
            random = new Random();
            Setup();
        }

        private void Setup()
        {
            nameList = File.ReadAllLines(paths["names"]);
            cityList = File.ReadAllLines(paths["cities"]);
        }

        public void AddElement(object element)
        {
            elements.Add(element);
        }

        public void ReadFromFile(string path)
        {
            AddElement(File.ReadAllLines(path));
        }

        public void ReadVectorFromFile(string path)
        {
            string delimiter;
            using (var file = new StreamReader(path))
            {
                if ((delimiter = file.ReadLine()).Length == 1)
                    if (int.TryParse(file.ReadLine(), out int repeat))
                    {
                        var toAdd = new VectorElement()
                        {
                            Delimiter = delimiter,
                            MaxRepeater = repeat
                        };

                        while (!file.EndOfStream)
                            toAdd.Elements.Add(file.ReadLine());

                        AddElement(toAdd);
                    }
            }
        }

        public void AddNumberRange(double min, double max)
        {
            AddElement(new double[] { min, max });
        }

        public void AddNumberRange(int min, int max)
        {
            AddElement(new int[] { min, max });
        }

        public void AddDateRange(DateTime start, DateTime end)
        {
            AddElement(new DateTime[] { start, end });
        }

        public string ToCSV()
        {
            string[] res = new string[elements.Count];

            for (int i = 0; i < res.Length; i++)
                res[i] += PickRandom(elements[i]);

            return String.Join(DefaultSeparator, res);
        }

        public string ToCSV(int lines)
        {
            string res = "";
            for (int i = 0; i < lines; i++)
                res += ToCSV() + "\r\n";

            return res.TrimEnd();
        }

        private string PickRandom(object o)
        {
            String res = "";

            if (o is string[] strings)
                res = strings[random.Next(strings.Length)];
            else if (o is double[] doubles)
                res = Math.Round(random.NextDouble() * (doubles[0] - doubles[1]) + doubles[1], 2).ToString().Replace(",", ".");
            else if (o is int[] integers)
                res = random.Next(integers[0], integers[1]+1).ToString();
            else if (o is DateTime[] dates)
                res = PickRandomDate(dates[0], dates[1]);
            else if (o is VectorElement vector)
                res = vector.Generate();

            return res;
        }

        private string PickRandomDate(DateTime start, DateTime end)
        {
            int range = (end - start).Days;
            return start.AddDays(random.Next(range+1)).ToString(DefaultDateFormat);
        }

        public void Clear()
        {
            elements.Clear();
        }

        public void RemoveLast()
        {
            if (elements.Count > 0)
                elements.RemoveAt(elements.Count - 1);
        }

        public void Remove(object o)
        {
            elements.Remove(o);
        }

        public void AddRandomNames()
        {
            AddElement(nameList);
        }

        public void AddRandomCities()
        {
            AddElement(cityList);
        }
    }
}
