using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14ex.Stop
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}",
                new string('.',n+1),
                new string('_',2*n+1));








            for (int row = 0; row < n; row++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}",
                    
                    new string('.', (n - row)),
                    new string('_', n * 2 - 1 + row*2)
                    );
                
            }
            Console.WriteLine("//{0}STOP!{0}\\\\",
                new string('_', ((n * 2 - 1 + n * 2) - 5) / 2));
            Console.WriteLine("\\\\{0}_____{0}//",
                new string('_', ((n * 2 - 1 + n * 2) - 5) / 2));


            for (int row = n-1; row > 0; row--)
            {
                Console.WriteLine("{0}\\\\{1}//{0}",

                    new string('.', (n - row)),
                    new string('_', n * 2 - 1 + row * 2)
                    );

            }
        }
    }
}
