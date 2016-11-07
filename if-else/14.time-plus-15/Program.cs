using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.time_plus_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            if (m + 15 >= 60)
            {
                h++;
                m = m + 15 - 60;
            }
            else
            {
                m = m + 15;
            }

            if (h == 24)
            {
                h = 0;
            }
            if (m < 10)
            {
                Console.WriteLine("{0}:0{1}", h, m);
            }
            else
            {
                Console.WriteLine("{0}:{1}", h, m);
            }

        }
    }
}
