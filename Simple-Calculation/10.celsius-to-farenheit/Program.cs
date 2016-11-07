using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.celsius_to_farenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());

            double farenhait = celsius * 1.8 + 32;

            Console.WriteLine(Math.Round(farenhait,2));

        }
    }
}
