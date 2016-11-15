using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.AddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int evenSumm = 0;
            int oddSumm = 0;

            for (int i = 1; i <= n; i++)
            {
                int newNum = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {

                    evenSumm += newNum;
                }
                else
                {
                    oddSumm += newNum;
                }
            }

            if (evenSumm == oddSumm)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}",evenSumm);
            }
            else
            {

                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}",Math.Abs( oddSumm - evenSumm));
            }


        }
    }
}
