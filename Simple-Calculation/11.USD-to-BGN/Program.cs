using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal bgn = decimal.Parse(Console.ReadLine());

            decimal levs = bgn * 1.79549m;

            Console.WriteLine(Math.Round(levs,2));
        }
    }
}
