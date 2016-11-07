using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17exam.Vegetable_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            float vegetablePrice = float.Parse(Console.ReadLine());
            float fruitPrice = float.Parse(Console.ReadLine());
            long vegetableKG = long.Parse(Console.ReadLine());
            long fruitKG = long.Parse(Console.ReadLine());

            float euroCoef = 1.94f;

            float vegetableProfit = vegetableKG * vegetablePrice;
            float fruitProfit = fruitKG * fruitPrice;

            float profitInLevs = fruitProfit + vegetableProfit;
            float profitInEuro = profitInLevs / euroCoef;

            Console.WriteLine(profitInEuro);

        }
    }
}
