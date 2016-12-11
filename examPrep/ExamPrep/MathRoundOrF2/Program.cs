using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathRoundOrF2
{
    class Program
    {
        static void Main(string[] args)
        {

            double d = 2.1;

            Console.WriteLine("{0}", Math.Round(d,2));
            Console.WriteLine("{0:0.##}", d);

            Console.WriteLine("{0:0}", d);

            Console.WriteLine("{0:0.00}", d);
            Console.WriteLine("{0:f2}", d);
            Console.WriteLine();

            d = 2.49999999;

            Console.WriteLine("{0}", Math.Round(d, 2));
            Console.WriteLine("{0:0.##}", d);

            Console.WriteLine("{0:0}", d);

            Console.WriteLine("{0:0.00}", d);
            Console.WriteLine("{0:f2}", d);

            Console.WriteLine();
            d = 2.39999999;

            Console.WriteLine("{0}", Math.Round(d, 2));
            Console.WriteLine("{0:0.##}", d);

            Console.WriteLine("{0:0}", d);

            Console.WriteLine("{0:0.00}", d);
            Console.WriteLine("{0:f2}", d);

        }
    }
}
