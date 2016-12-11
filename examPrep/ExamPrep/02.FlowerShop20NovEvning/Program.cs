using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FlowerShop20NovEvning
{
    class Program
    {
        static void Main(string[] args)
        {


            int magnolias = int.Parse(Console.ReadLine());
            int ziumbiuli = int.Parse(Console.ReadLine());

            int roses = int.Parse(Console.ReadLine());

            int cactus = int.Parse(Console.ReadLine());

            double giftPrice = double.Parse(Console.ReadLine());


            double summ = magnolias * 3.25d + ziumbiuli * 4d + roses * 3.50d + cactus * 8d;
            summ = summ - summ * 0.05;

            if (summ >= giftPrice)
            {
                Console.WriteLine("She is left with {0:0} leva.",Math.Floor(summ - giftPrice));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.",Math.Ceiling(giftPrice - summ));
            }





        }
    }
}
