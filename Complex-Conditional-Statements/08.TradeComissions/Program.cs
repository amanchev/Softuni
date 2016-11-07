using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double summ = double.Parse(Console.ReadLine());

            double first = 0;
            double second = 0;
            double third = 0;
            double fourth = 0;

            bool isError = false;

            switch (town)
            {
                case "Sofia":
                    first = 5d/100;
                    second = 7d/100;
                    third = 8d/100;
                    fourth = 12d/100;
                    break;
                case "Varna":
                    first = 4.5d/100;
                    second = 7.5d/100;
                    third = 10d/100;
                    fourth = 13d/100;
                    break;
                case "Plovdiv":
                    first = 5.5d/100;
                    second = 8d/ 100;
                    third = 12d/100;
                    fourth = 14.5d/100;
                    break;

                default:
                    isError = true;
                    break;
            }

            double result = -1;

            if (summ >= 0 && summ <= 500)
            {
                result = summ * first;
            }
            else if (summ > 500 && summ <= 1000)
            {
                result = summ * second;
            }
            else if (summ > 1000 && summ <= 10000)
            {
                result = summ * third;
            }
            else if (summ > 10000)
            {
                result = summ * fourth;
            }
            else
            {
                isError = true;
            }

            if (!isError)
            {
                Console.WriteLine("{0:f2}", result);
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
