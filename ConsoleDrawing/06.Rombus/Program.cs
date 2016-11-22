using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rombus
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row < n; row++)
            {
                Console.Write("{0}", new string(' ', n-row));
                Console.Write("*");
                for (int j = 0; j < row - 1; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            for (int row = n; row > 0; row--)
            {
                Console.Write("{0}", new string(' ', n - row));
                Console.Write("*");
                for (int j = 0; j < row - 1; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }



        }
    }
}
