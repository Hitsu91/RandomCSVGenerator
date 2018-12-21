using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 2;
            //int b = 44;

            //(a, b) = (b, a);

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            int[] num = { 1, 3 };

            (num[0], num[1]) = (num[1], num[0]);

            Console.WriteLine(String.Join("," , num));

            Console.ReadKey();
        }
    }
}
