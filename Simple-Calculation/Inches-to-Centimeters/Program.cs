using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("inches = ");
                decimal inches = decimal.Parse(Console.ReadLine());
                decimal centimeters = inches * 2.54m;
                Console.WriteLine("Centimeters = {0}", centimeters);
            } while (false);

    

    
        }
    }
}
