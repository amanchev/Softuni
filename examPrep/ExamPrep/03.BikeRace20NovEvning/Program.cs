using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BikeRace20NovEvning
{
    class Program
    {
        static void Main(string[] args)
        {
            int junior = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine();

            double juniorTax = 0;
            double seniorsTax = 0;

            switch (trace)
            {
                case "trail":
                    juniorTax = 5.5;
                    seniorsTax = 7;
                    break;
                case "cross-country":
                    juniorTax = 8;
                    seniorsTax = 9.5;
                    break;
                case "downhill":
                    juniorTax = 12.25;
                    seniorsTax = 13.75;
                    break;
                case "road":
                    juniorTax = 20;
                    seniorsTax = 21.5;
                    break;
            }

            double juniorProfit = junior * juniorTax;
            double seniorProfit = seniors * seniorsTax;

            double profit = juniorProfit + seniorProfit;

            if (trace == "cross-country" && junior + seniors >= 50)
            {
                profit = profit - profit * 0.25;
            }

            profit = profit - profit * 0.05;

            Console.WriteLine("{0:f2}",profit);


        }
    }
}
