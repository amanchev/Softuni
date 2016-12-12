using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StupidPassGenerator6March
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int n1 = 1; n1 <= n; n1++)
            {
                for (int n2 = 1; n2 < n; n2++)
                {
                    for (char b1 = 'a'; b1 < 'a'+l; b1++)
                    {
                        for (char b2 = 'a'; b2 < 'a' + l; b2++)
                        {
                            for (int n3 = Math.Max(n1,n2)+1; n3 <= n; n3++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ",
                                n1, n2, b1, b2, n3);
                            }
                        }
                    }
                }
            }



        }
    }
}
