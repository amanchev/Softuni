using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n%2==0)
            {
                    int k = 0;

                for (int i = 0; i < (n+1)/2; i++)
                {
                    Console.WriteLine("{0}{1}{0}",
                        new string('-', n/2  - k/2 - 1),
                        new string('*', k + 2));
                    k += 2;
                }
                for (int i = 0; i < (n + 1) / 2; i++)
                {
                    Console.WriteLine("|{0}|", new string('*', n - 2));
                }

            }
            else
            {
                int k = 0;
                for (int i = (n+2)/2; i > 0; i--)
                {
                    Console.WriteLine("{0}{1}{0}",
                        new string('-', n/2 - k/2  ),
                        new string('*', k + 1));
                    k += 2;

                }
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine("|{0}|", new string('*', n - 2));
                }
            }


            
        }
    }
}
