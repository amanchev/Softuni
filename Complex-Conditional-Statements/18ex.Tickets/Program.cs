using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18ex.Tickets
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal budget = decimal.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            decimal price = -1;
            decimal percent = -1;

            if (type == "VIP")
            {
                price = 499.99m;
            }
            else
            {
                price = 249.99m;
            }

            if (people <= 4)
            {
                percent = 0.75m;
            }
            else if (people <= 9)
            {
                percent = 0.6m;
            }
            else if (people <= 24)
            {
                percent = 0.5m;
            }
            else if (people <= 49)
            {
                percent = 0.4m;
            }
            else
            {
                percent = 0.25m;
            }

            decimal budgetForTitckets = budget - (budget * percent);

            decimal sum = people * price;

            if (sum <= budgetForTitckets)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", budgetForTitckets - sum);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", sum - budgetForTitckets);
            }

        }
    }
}
