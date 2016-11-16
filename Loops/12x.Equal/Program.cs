using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12x.Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int lastSum = 0;
            bool isAllEqual = true;
            int maxDiff = 0;
        

            for (int i = 0; i < n; i++)
            {


                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int num = a + b;
                    sum = sum + num;
                

                if ( i!=0 && sum != lastSum)
                {
                    isAllEqual = false;

                    if (Math.Abs(sum - lastSum) > maxDiff)
                    {
                        maxDiff = Math.Abs(sum - lastSum);

                    }

                }
                


                lastSum = sum;
                sum = 0;

            }

            if (isAllEqual)
            {
                Console.WriteLine("Yes, value={0}",lastSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}",maxDiff);
            }

        }
    }
}
