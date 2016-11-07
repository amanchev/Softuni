
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Voleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int bankHolydays = int.Parse(Console.ReadLine());
            int travelWeekend = int.Parse(Console.ReadLine());

            

            double saturdaysInSofiaGames = (48 - travelWeekend) * 3d / 4d;

            double sundaysInSofia = bankHolydays * 2d / 3d;

            double playDays = saturdaysInSofiaGames + sundaysInSofia + travelWeekend;

            if (year == "leap")
            {
                playDays = playDays + playDays * 0.15;
            }

            Console.WriteLine(Math.Truncate(playDays));

        }
    }
}
