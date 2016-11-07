using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            


                int num = int.Parse(Console.ReadLine());


                double result = num;

                if (num <= 100)
                {
                    result += 5;
                }
                else if (num > 100 && num <= 1000)
                {
                    result = result + result * 20 / 100;
                }
                else if (num > 1000)
                {
                    result = result + result * 10 / 100;
                }

                if (num % 2 == 0)
                {
                    result += 1;
                }else if (num % 5 == 0)
                {
                    result = result + 2;
                }

                Console.WriteLine(result - num);
                Console.WriteLine(result);
            }
        
    }
}
