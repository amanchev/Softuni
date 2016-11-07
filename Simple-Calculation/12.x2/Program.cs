using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.x2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal summ = decimal.Parse(Console.ReadLine());
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            decimal usd = 1.79549m;
            decimal eur = 1.95583m;
            decimal gbp = 2.53405m;

            decimal result = 0.0m;

            if (first == "BGN")
            {
                if (second == "USD")
                {
                    result = summ / usd;
                    
                }
                else if (second == "EUR")
                {
                   result = summ / eur;

                }
                else if(second == "GBP")
                {
                    result = summ / gbp;

                }
            }
            else if (first == "USD")
            {
                if (second == "BGN")
                {
                    result = summ * usd;
                }
                else if (second == "EUR")
                {
                    result = summ * usd / eur;

                }
                else if (second == "GBP")
                {
                    result = summ * usd / gbp;

                }

            }
            else if (first == "EUR")
            {
                if (second == "BGN")
                {
                    result = summ * eur;
                }
                else if (second == "USD")
                {
                    result = summ * eur / usd;
                }
                else if (second == "GBP")
                {
                    result = summ * eur / gbp;
                }

            }
            else if (first == "GBP")
            {
                if (second == "BGN")
                {
                    result = summ * gbp;
                }
                else if (second == "USD")
                {
                    result = summ * gbp / usd;
                }
                else if (second == "EUR")
                {
                    result = summ / eur * gbp;
                }
            }

            Console.WriteLine(Math.Round(result,2));

        }
    }
}
