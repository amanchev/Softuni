using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Print_num_with_word
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            //if (num == 0)
            //{
            //    Console.WriteLine("zero");
            //}
            //else if(num == 1)
            //{
            //    Console.WriteLine("one");
            //}
            //else if (num == 2)
            //{
            //    Console.WriteLine("two");
            //}
            //else if (num == 3)
            //{
            //    Console.WriteLine("three");
            //}
            //else if (num == 4)
            //{
            //    Console.WriteLine("four");
            //}
            //else if (num == 5)
            //{
            //    Console.WriteLine("five");
            //}
            //else if (num == 6)
            //{
            //    Console.WriteLine("six");
            //}
            //else if (num == 7)
            //{
            //    Console.WriteLine("seven");
            //} 
            //else if (num == 8)
            //{
            //    Console.WriteLine("eight");
            //}
            //else if (num == 9)
            //{
            //    Console.WriteLine("nine");
            //}
            //else 
            //{
            //    Console.WriteLine("number too big");
            //}

            switch (num)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");

                    break;
                case 3:
                    Console.WriteLine("three");

                    break;
                case 4:
                    Console.WriteLine("four");

                    break;
                case 5:
                    Console.WriteLine("five");

                    break;
                case 6:
                    Console.WriteLine("six");

                    break;
                case 7:
                    Console.WriteLine("seven");

                    break;
                case 8:
                    Console.WriteLine("eight");

                    break;
                case 9:
                    Console.WriteLine("nine");

                    break;
                default:
                    Console.WriteLine("number too big");

                    break;
            }

        }
    }
}
