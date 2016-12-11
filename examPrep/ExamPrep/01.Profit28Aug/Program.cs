using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Profit28Aug
{
    class Program
    {
        static void Main(string[] args)
        {

            int workingDays = int.Parse(Console.ReadLine());
            double moneyPerDay = double.Parse(Console.ReadLine());
            double usdPrice = double.Parse(Console.ReadLine());

            double monthProfit = workingDays * moneyPerDay;
            double yearsProfit = monthProfit * 12 + monthProfit * 2.5;

            double debt = 0.25 * yearsProfit;

            double cleanYearProfit = yearsProfit - debt;
            double result = cleanYearProfit / 365 * usdPrice ;

            Console.WriteLine("{0:f2}", result);


        }
    }
}
