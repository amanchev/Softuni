using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double workingHours = 8d * (days - (days * 10d / 100d));

            workingHours = workingHours + workers * 2 * days;

            workingHours = Math.Floor(workingHours);

            if (workingHours >= hours)
            {
                Console.WriteLine("Yes!{0} hours left.", workingHours - hours);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", hours - workingHours);
            }

        }
    }
}
