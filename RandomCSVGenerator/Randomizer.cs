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

        private List<IRandomObj> elements;
        private RandomString nameList;
        private RandomString cityList;
        public static string DefaultSeparator { get; set; } = ",";
        public static string DefaultDateFormat { get; set; } = dateFormats[0];

        public Randomizer()
        {
            elements = new List<IRandomObj>();
            Setup();
        }

        private void Setup()
        {
            nameList = new RandomString { Strings = File.ReadAllLines(paths["names"]) };
            cityList = new RandomString { Strings = File.ReadAllLines(paths["cities"]) };
        }

        public void AddElement(IRandomObj element)
        {
            elements.Add(element);
        }

        public void ReadFromFile(string path)
        {
            AddElement(new RandomString() { Strings = File.ReadAllLines(path) });
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
            AddElement(new RandomDouble {Min= min, Max=max });
        }

        public void AddNumberRange(int min, int max)
        {
            AddElement(new RandomInt {Min= min, Max=max });
        }

        public void AddDateRange(DateTime start, DateTime end)
        {
            AddElement(new RandomDate { Start = start, End= end });
        }

        public string ToCSV()
        {
            string[] res = new string[elements.Count];

            for (int i = 0; i < res.Length; i++)
                res[i] += elements[i].Generate();

            return String.Join(DefaultSeparator, res);
        }

        public string ToCSV(int lines)
        {
            string res = "";
            for (int i = 0; i < lines; i++)
                res += ToCSV() + "\r\n";

            return res.TrimEnd();
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

        public void Remove(IRandomObj o)
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
