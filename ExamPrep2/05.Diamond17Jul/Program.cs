using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond17Jul
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 5 * n;

            Console.WriteLine("{0}{1}{0}",
                new string('.',n),
                new string('*',width - 2*n)
                );

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                new string('.', n -i),
                new string('.', width - 2 * (n-i) - 2)
                );
            }

            Console.WriteLine(new string('*',width));

            for (int i = 1; i <= n*2 + 1; i++)
            {
                if (i!=n*2+1)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                new string('.', i),
                new string('.', width - 2 * i - 2)
                );
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{0}",
                new string('.', i),
                new string('*', width - 2 * i - 2)
                );
                }
            }


        }
    }
}
