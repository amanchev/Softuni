using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16exam.classroom
{
    class adf
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

            w = w - 1d;

            w = w / 0.7d;

            w = Math.Floor(w);

            h = h / 1.2d;
            h = Math.Floor(h);


            double result = w * h - 3;

            Console.WriteLine(result);

        }
    }
}
