using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftuniCamp
{
    class Program
    {
        static void Main(string[] args)
        {

            int groups = int.Parse(Console.ReadLine());

            double peopleInCar = 0;
            double peopleInBus = 0;
            double peopleInSmallBus = 0;
            double peopleInBigBus = 0;
            double peopleInTrain = 0;




            for (int i = 0; i < groups; i++)
            {

                int peopleInThisGroup = int.Parse(Console.ReadLine());

                if (peopleInThisGroup <= 5)
                {
                    peopleInCar += peopleInThisGroup;
                }
                else if (peopleInThisGroup <= 12)
                {
                    peopleInBus += peopleInThisGroup;
                }
                else if (peopleInThisGroup <= 25)
                {
                    peopleInSmallBus += peopleInThisGroup;
                }
                else if (peopleInThisGroup <= 40)
                {
                    peopleInBigBus += peopleInThisGroup;
                }
                else
                {
                    peopleInTrain += peopleInThisGroup;
                }

            }

            double totalPeople = peopleInCar + peopleInBus + peopleInSmallBus + peopleInBigBus + peopleInTrain;

            double carPercent = 100 - (totalPeople - peopleInCar) * 100 / totalPeople;
            double busPercent = 100 - (totalPeople - peopleInBus) / totalPeople * 100;
            double smallBusPercent = 100 - (totalPeople - peopleInSmallBus) / totalPeople * 100;
            double bigBusPercent = 100 - (totalPeople - peopleInBigBus) / totalPeople * 100;
            double trainPercent = 100 - (totalPeople - peopleInTrain) / totalPeople * 100;

            Console.WriteLine("{0:0.00}%", carPercent);
            Console.WriteLine("{0:0.00}%", busPercent);
            Console.WriteLine("{0:0.00}%", smallBusPercent);
            Console.WriteLine("{0:0.00}%", bigBusPercent);
            Console.WriteLine("{0:0.00}%", trainPercent);


        }
    }
}
