using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Metric_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            double meters = 0;

            
                switch (first)
                {
                    case "m":
                        meters = num;
                        break;
                    case "mm":
                        meters = num / 1000;
                        break;
                    case "cm":
                        meters = num / 100;
                        break;
                    case "mi":
                        meters = num / 0.000621371192;
                        break;
                    case "in":
                        meters = num / 39.3700787;
                        break;
                    case "km":
                        meters = num / 0.001;
                        break;
                    case "ft":
                        meters = num / 3.2808399;
                        break;
                    case "yd":
                        meters = num / 1.0936133;
                        break;

                    default:
                        break;
                
            }

            double result = 0;

            switch (second)
            {
                case "m":
                    result = meters;
                    break;
                case "mm":
                    result = meters * 1000;
                    break;
                case "cm":
                    result = meters * 100;
                    break;
                case "mi":
                    result = meters * 0.000621371192;
                    break;
                case "in":
                    result = meters * 39.3700787;
                    break;
                case "km":
                    result = meters * 0.001;
                    break;
                case "ft":
                    result = meters * 3.2808399;
                    break;
                case "yd":
                    result = meters * 1.0936133;
                    break;

                default:
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
