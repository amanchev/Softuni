using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double qwantity = double.Parse(Console.ReadLine());
            double banana = 0;
            double apple = 0;
            double orange = 0;
            double grapefruit = 0;
            double kiwi = 0;
            double pineapple = 0;
            double grapes = 0;
            bool isError = false;



            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    {
                        banana = 2.5;
                        apple = 1.2;
                        orange = 0.85;
                        grapefruit = 1.45;
                        kiwi = 2.7;
                        pineapple = 5.5;
                        grapes = 3.85;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    {
                        banana = 2.7;
                        apple = 1.25;
                        orange = 0.9;
                        grapefruit = 1.6;
                        kiwi = 3.0;
                        pineapple = 5.6;
                        grapes = 4.2;
                    }
                    break;
                default:
                    isError = true;
                    break;

                
              }

            double result = -1.0;

            switch (fruit)
            {
                case "banana":
                    result = banana * qwantity;
                    break;
                case "apple":
                    result = apple * qwantity;
                    break;
                case "orange":
                    result = orange * qwantity;
                    break;
                case "grapefruit":
                    result = grapefruit * qwantity;
                    break;
                case "kiwi":
                    result = kiwi * qwantity;
                    break;
                case "pineapple":
                    result = pineapple * qwantity;
                    break;
                case "grapes":
                    result = grapes * qwantity;
                    break;

                default:
                    isError = true;
                    break;
              
            }

            if (!isError)
            {
                Console.WriteLine("{0:f2}",result);
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
