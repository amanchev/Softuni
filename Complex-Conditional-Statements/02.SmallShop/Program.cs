using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double qwantity = double.Parse(Console.ReadLine());
            double coffe = 0;
            double water = 0;
            double beer = 0;
            double sweets = 0;
            double peanuts = 0;



            if (town == "Sofia")
            {
                coffe = 0.5;
                water = 0.8;
                beer = 1.2;
                sweets = 1.45;
                peanuts = 1.6;
            }
            else if (town == "Plovdiv")
            {
                coffe = 0.4;
                water = 0.7;
                beer = 1.15;
                sweets = 1.30;
                peanuts = 1.5;
            }
            else
            {
                coffe = 0.45;
                water = 0.7;
                beer = 1.1;
                sweets = 1.35;
                peanuts = 1.55;
            }

            double result = 0;

            switch (product)
            {
                case "coffee":
                    result = coffe * qwantity;
                    break;
                case "water":
                    result = water * qwantity;
                    break;
                case "beer":
                    result = beer * qwantity;
                    break;
                case "sweets":
                    result = sweets * qwantity;
                    break;
                case "peanuts":
                    result = peanuts * qwantity;
                    break;
                    
                default:
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
