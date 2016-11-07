using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string priceType = Console.ReadLine();
            double r = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double result = -1;

            switch (priceType)
            {
                case "Premiere":
                    result = 12d * r * c;
                    break;
                case "Normal":
                    result = 7.5d * r * c;
                    break;
                case "Discount":
                    result = 5d * r * c;
                    break;

                default:
                    break;
            }
            Console.WriteLine("{0:f2}",result);
        }
    }
}
