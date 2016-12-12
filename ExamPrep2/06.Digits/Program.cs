using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Digits
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int hundreds = (n / 100)%10;
            int tens = (n / 10) % 10;
            int ones = n % 10;

            int row = hundreds + tens;
            int col = hundreds + ones;

            int counter = 0;

            int number = n;

            for (int i = 0; i < row*col; i++)
            {

                if (number % 5 == 0)
                {
                    number = number - hundreds;

                }
                else if (number%3==0)
                {
                    number = number - tens;
                }
                else
                {
                    number = number + ones;
                }

                Console.Write("{0} ", number);

                counter++;

                if (counter == col)
                {
                    Console.WriteLine();
                    counter = 0;
                }
            }



        }
    }
}
