using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12x.Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal summ = decimal.Parse(Console.ReadLine());
            string firstVal = Console.ReadLine();
            string secondVal = Console.ReadLine();

            decimal usd = 1.79549m;
            decimal eur = 1.95583m;
            decimal gbp = 2.53405m;

            decimal result = 0m;

            //if (firstVal == "BGN")
            //{
            //    if (secondVal == "USD")
            //    {
            //        result = summ / usd;
            //    }
            //    else if (secondVal == "EUR")
            //    {
            //        result = summ / eur;
            //    }
            //    else if (secondVal == "GBP")
            //    {
            //        result = summ / gbp;
            //    }
            //}
            //else if (firstVal == "USD")
            //{
            //    if (secondVal == "BGN")
            //    {
            //        result = summ * usd;
            //    }
            //    else if (secondVal == "EUR")
            //    {
            //        result = summ * usd / eur;
            //    }
            //    else if (secondVal == "GBP")
            //    {
            //        result = summ * usd / gbp;
            //    }
            //}
            //else if (firstVal == "EUR")
            //{
            //    if (secondVal == "USD")
            //    {
            //        result = summ * eur / usd;

            //    }
            //    else if (secondVal == "BGN")
            //    {
            //        result = summ * eur;

            //    }
            //    else if (secondVal == "GBP")
            //    {
            //        result = summ * eur / gbp;

            //    }
            //}
            //else if (firstVal == "GBP")
            //{
            //    if (secondVal == "USD")
            //    {
            //        result = summ * gbp / usd;

            //    }
            //    else if (secondVal == "EUR")
            //    {
            //        result = summ * gbp / eur;

            //    }
            //    else if (secondVal == "BGN")
            //    {
            //        result = summ * gbp;

            //    }
            //}


            switch (firstVal)
            {
                case "BGN":
                    {
                        switch (secondVal)
                        {
                            case "USD":
                                result = summ / usd;
                                break;
                            case "EUR":
                                result = summ / eur;

                                break;
                            case "GBP":
                                result = summ / gbp;

                                break;
                            default:
                                Console.WriteLine("ERROR1");
                                break;
                        }
                    }
                    break;

                case "USD":
                    {
                        switch (secondVal)
                        {
                            case "BGN":
                                result = summ * usd;
                                break;
                            case "EUR":
                                result = summ * usd / eur;


                                break;
                            case "GBP":
                                result = summ * usd / gbp;

                                break;
                            default:
                                Console.WriteLine("ERROR2");
                                break;
                        }
                    }
                    break;
                case "EUR":
                    {
                        switch (secondVal)
                        {
                            case "BGN":
                                result = summ * eur;
                                break;
                            case "USD":
                                result = summ * eur / usd;


                                break;
                            case "GBP":
                                result = summ * eur / gbp;

                                break;
                            default:
                                Console.WriteLine("ERROR3");
                                break;
                        }
                    }
                    break;
                case "GBP":
                    {
                        switch (secondVal)
                        {
                            case "BGN":
                                result = summ * gbp;
                                break;
                            case "EUR":
                                result = summ * gbp / eur;


                                break;
                            case "USD":
                                result = summ * gbp / usd;

                                break;
                            default:
                                Console.WriteLine("ERROR4");
                                break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("ERROR0");

                    break;
            }

            Console.WriteLine(Math.Round(result, 2));
        }
    }
}
