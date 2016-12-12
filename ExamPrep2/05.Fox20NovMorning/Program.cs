using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox20NovMorning
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int width = n * 2 + 3;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}",
                    new string('*', i),
                    new string('-', width - 2 - i*2)
                    );
            }
            for (int i = 0; i < n/3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|",
                    new string('*', (width - 4 - (n - 2 * i))/2),
                    new string('*', n-2*i )
                    );
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}",
                    new string('-', i),
                    new string('*', width - 2 - i*2)
                    );
            }

        }
    }
}
