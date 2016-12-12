using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Histogram6March
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;
            int n5 = 0;

            for (int i = 0; i < n; i++)
            {

                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    n1++;
                }
                else if (num <= 399)
                {
                    n2++;
                }
                else if (num <= 599)
                {
                    n3++;
                }
                else if (num <= 799)
                {
                    n4++;
                }
                else
                {
                    n5++;

                }

             }

            double allNum = n1 + n2 + n3 + n4 + n5;

            Console.WriteLine("{0:0.00}%", n1 / allNum * 100);
            Console.WriteLine("{0:0.00}%", n2 / allNum * 100);
            Console.WriteLine("{0:0.00}%", n3 / allNum * 100);
            Console.WriteLine("{0:0.00}%", n4 / allNum * 100);
            Console.WriteLine("{0:0.00}%", n5 / allNum * 100);


        }
    }
}
