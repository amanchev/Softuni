using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EvenOrOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = 1000000000.0;
            double oddMax = -1000000000.0;
            double evenSum = 0;
            double evenMin = 1000000000.0;
            double evenMax = -1000000000.0;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    evenSum += num;
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                }
            }

            Console.WriteLine("OddSum={0}",oddSum);


            if (oddMin == 1000000000.0)
            {
                Console.WriteLine("OddMin=No");

            }
            else
            {
                Console.WriteLine("OddMin={0}", oddMin);

            }
            if (oddMax == -1000000000.0)
            {
                Console.WriteLine("OddMax=No");

            }
            else
            {
                Console.WriteLine("OddMax={0}", oddMax);

            }
            
            Console.WriteLine("EvenSum={0}",evenSum);

            if (evenMin == 1000000000.0)
            {
                Console.WriteLine("EvenMin=No");

            }
            else
            {
                Console.WriteLine("EvenMin={0}", evenMin);

            }
            if (evenMax == -1000000000.0)
            {
                Console.WriteLine("EvenMax=No");

            }
            else
            {
                Console.WriteLine("EvenMax={0}", evenMax);

            }


        }
    }
}
