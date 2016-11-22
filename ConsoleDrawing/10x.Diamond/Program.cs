using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10x.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {

                

                for (int i = 0; i < n / 2; i++)
                {
                  Console.WriteLine("{0}*{1}*{0}",
                        new string('-', n / 2 - i - 1),
                        new string('-', i * 2));
                }

                for (int i = n / 2 - 2; i >= 0; i--)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', n / 2 - i - 1),
                        new string('-', i * 2));
                }

            }
            else if (n != 1)
            {
                Console.WriteLine("{0}*{0}", new string('-', (n - 1) / 2));
                for (int i = 1; i <= n / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', (n - 1) / 2 - i),
                        new string('-', i * 2 - 1));
                }

                for (int i = n / 2 - 1; i >= 1; i--)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', (n - 1) / 2 - i),
                        new string('-', i * 2 - 1));
                }
                Console.WriteLine("{0}*{0}", new string('-', n / 2));

            }
            else
            {
                Console.WriteLine('*');
            }
        }
    }
}
