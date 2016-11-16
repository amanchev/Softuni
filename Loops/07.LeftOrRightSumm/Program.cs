using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LeftOrRightSumm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int left = 0;
            int right = 0;

            for (int i = 0; i < n; i++)
            {
                int newNum = int.Parse(Console.ReadLine());
                left = left + newNum;
            }
            for (int i = n; i < 2 * n ; i++)
            {
                int newNum = int.Parse(Console.ReadLine());
                right += newNum;
            }
            

            if (left == right)
            {
                Console.WriteLine("Yes, sum = {0}", left);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(left - right) );
            }

        }
    }
}
