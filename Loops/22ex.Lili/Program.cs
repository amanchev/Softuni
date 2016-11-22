using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22ex.Lili
{
    class Program
    {
        static void Main(string[] args)
        {


            int age = int.Parse(Console.ReadLine());

            double price = double.Parse(Console.ReadLine());
            
            double toyPrice = double.Parse(Console.ReadLine());

            double sum = 0;
            int toysCount = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    sum += (10d * i / 2d) - 1d;
                   
                }
                else
                {
                    toysCount++;
                }
            }

            sum += toysCount * toyPrice;

            if (sum >= price)
            {
                Console.WriteLine("Yes! {0:f2}", sum - price);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", price - sum);
            }


        }
    }
}
