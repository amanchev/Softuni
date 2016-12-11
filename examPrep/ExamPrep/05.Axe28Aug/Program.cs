using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Axe28Aug
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-',n*3),
                    new string('-',i),
                    new string('-', width - 2 - n*3 - i)
                    );
            }

            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('*', n * 3),
                    new string('-', n-1),
                    new string('-', width - n * 3 - n-1)
                    );
            }

            for (int i = 0; i < (n / 2); i++)
            {
                if (i < (n/2)-1 )
                {
                    Console.WriteLine("{0}*{1}*{2}",
                    new string('-', n * 3 - i),
                    new string('-', n - 1 + 2 * i),
                    new string('-', width - n * 3 - n - 1 - i)
                    );
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{2}",
                    new string('-', n * 3 - i),
                    new string('*', n - 1 + 2 * i),
                    new string('-', width - n * 3 - n - 1 - i)
                    );
                }
                

            }




        }
    }
}
