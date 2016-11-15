using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10x.EqualToSumm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int summ = 0;

            for (int i = 0; i < n; i++)
            {
                int newNum = int.Parse(Console.ReadLine());

                if (newNum > max)
                {
                    max = newNum;
                }

                summ += newNum;
            }
            summ = summ - max;
            if (max == summ)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", summ);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(max - summ));
            }
        }
    }
}
