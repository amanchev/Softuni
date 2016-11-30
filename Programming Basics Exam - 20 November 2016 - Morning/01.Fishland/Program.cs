using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {

            double skumriaPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudKG = double.Parse(Console.ReadLine());
            double safridKG = double.Parse(Console.ReadLine());
            double midiKG = double.Parse(Console.ReadLine());

            double palamudPrice = skumriaPrice * 0.6 + skumriaPrice;
            double safridPrice = cacaPrice * 0.8 + cacaPrice;
            double midiPrice = 7.5;

            double palamudSum = palamudPrice * palamudKG;
            double safridSum = safridKG * safridPrice;
            double midiSum = midiKG * midiPrice;

            double result = palamudSum + safridSum + midiSum;

            Console.WriteLine("{0:0.00}",result);


        }
    }
}
