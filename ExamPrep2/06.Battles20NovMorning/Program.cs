using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxCombination20NovEvning
{
    class Program
    {
        static void Main(string[] args)
        {

            int first = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 1; i <= first && counter < max; i++)
            {
                for (int j = 1; j <= last && counter < max; j++)
                {
                    Console.Write("({0} <-> {1}) ", i, j);
                    counter++;

                }

            }

        }
    }
}

   
