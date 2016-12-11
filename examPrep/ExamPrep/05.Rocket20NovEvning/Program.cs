using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket20NovEvning
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());

            int width = n * 3;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}",
                    new string('.', width / 2 - 1 - i),
                    new string(' ', i * 2)
                    );
            }


            Console.WriteLine("{0}{1}{0}",
                new string('.',n/2),
                new string('*',width - n)
                );

            for (int i = 0; i < 2*n; i++)
            {
                Console.WriteLine("{0}|{1}|{0}",
                new string('.', n / 2),
                new string('\\', width - n - 2)
                );
            }

            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}",
                new string('.', n / 2 - i),
                new string('*', width - n - 2 + i*2)


                    );
            }









        }
    }
}
