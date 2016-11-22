using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamIlluminatiLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}",
                new string('.',n),
                new string('#',n));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}"
                    ,new string('.', n - i*2 - 2),
                    new string('.', i*2),
                    new string('.', n - 2)
                    );
            }

            for (int i = 0; i <= n / 2; i++)
            {
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}",
                    new string('.', 1 + i*2),
                    new string('.', n - 2 - 1 - i*2),
                    new string('.', n - 2)
                    );
            }



            Console.WriteLine("{0}{1}{0}",
                new string('.', n),
                new string('#', n));

        }
    }
}
