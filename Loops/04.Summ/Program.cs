using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Summ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int summ = 0;

            for (int i = 0; i < n; i++)
            {
                int newNum = int.Parse(Console.ReadLine());

                summ += newNum;
            }

            Console.WriteLine(summ);
        }
    }
}
