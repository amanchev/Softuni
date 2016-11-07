using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16ex.Numbers_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            char ch = char.Parse(Console.ReadLine());

            if ((ch == '/' || ch == '%') && n2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero",n1);
            }
            else if (ch == '+' || ch == '-' || ch == '*')
            {
                int result = 0;
                string isEven = "";

                if (ch =='+')
                {
                    result = n1 + n2;
                    if (result % 2 == 0)
                    {
                        isEven = "even";
                    }
                    else
                    {
                        isEven = "odd";
                    }
                }
                else if (ch == '-')
                {
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        isEven = "even";
                    }
                    else
                    {
                        isEven = "odd";
                    }
                }
                else
                {
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        isEven = "even";
                    }
                    else
                    {
                        isEven = "odd";
                    }
                }

                Console.WriteLine("{0} {1} {2} = {3} - {4}", n1,ch,n2,result,isEven);
            }
            else if (ch == '/')
            {
                double result = (double)n1/ (double)n2;
                Console.WriteLine("{0} / {1} = {2:f2}", n1, n2, result);
            }
            else if (ch == '%')
            {
                int result = n1 % n2;

                Console.WriteLine("{0} % {1} = {2}",n1,n2,result);
            }

        }
    }
}
