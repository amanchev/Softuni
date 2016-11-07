using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Three_equals_number
{
    public class Class1
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());


            if (n1 == n2)
            {
                if (n1==n3)
                {
                    Console.WriteLine("yes");

                }
                else
                {
                    Console.WriteLine("no");

                }
            }
            else
            {
                Console.WriteLine("no");
            }



        }
    }
}
