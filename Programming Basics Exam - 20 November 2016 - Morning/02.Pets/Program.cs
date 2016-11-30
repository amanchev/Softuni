using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {

            double days = double.Parse(Console.ReadLine());
            double foodKg = double.Parse(Console.ReadLine());
            double dogFoodKg = double.Parse(Console.ReadLine());
            double catFoodKg = double.Parse(Console.ReadLine());
            double turtleFoodKg = double.Parse(Console.ReadLine()) / 1000.0;

            double dogFoodNeeded = days * dogFoodKg;
            double catFoodNeeded = days * catFoodKg;
            double turtleFoodNeeded = days * turtleFoodKg;

            double allFoodNeeded = dogFoodNeeded + turtleFoodNeeded + catFoodNeeded;

            if (allFoodNeeded <= foodKg)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodKg - allFoodNeeded));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.",Math.Ceiling(allFoodNeeded-foodKg));
            }

        }
    }
}
