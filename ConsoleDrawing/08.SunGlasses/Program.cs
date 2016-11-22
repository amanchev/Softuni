using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SunGlasses
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('*',n*2),new string(' ', n));

            if (n%2==0)
            {
                for (int i = 0; i < n / 2 - 2; i++)
                {
                    Console.WriteLine("*{0}*{1}*{0}*",
                        new string('/', n * 2 - 2),
                        new string(' ', n));
                }
            }
            else
            {
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    Console.WriteLine("*{0}*{1}*{0}*",
                        new string('/', n * 2 - 2),
                        new string(' ', n));
                }
            }

            Console.WriteLine("*{0}*{1}*{0}*",
                new string('/',n*2-2),
                new string('|', n));

            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("*{0}*{1}*{0}*",
                    new string('/', n * 2 - 2),
                    new string(' ', n));
            }

            Console.WriteLine("{0}{1}{0}", new string('*',n*2),new string(' ', n));

        }
    }
}
