using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SummLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int summ = 0;

            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':
                        summ ++;
                        break;
                    case 'e':
                        summ += 2;
                        break;
                    case 'i':
                        summ += 3;
                        break;
                    case 'o':
                        summ += 4;
                        break;
                    case 'u':
                        summ += 5;
                        break;
                }
            }


            Console.WriteLine(summ);
        }
    }
}
