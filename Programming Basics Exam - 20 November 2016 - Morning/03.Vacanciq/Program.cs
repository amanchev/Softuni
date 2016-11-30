using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacanciq
{
    class Program
    {
        static void Main(string[] args)
        {

            int oldPeople = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int nightsCount = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            double oldPeoplePrice = 0;
            double studentsPrice = 0;


            switch (transport)
            {
                case "train":
                    oldPeoplePrice = 24.99;
                    studentsPrice = 14.99;
                    if (oldPeople + students >= 50)
                    {
                        oldPeoplePrice = oldPeoplePrice / 2.0;
                        studentsPrice = studentsPrice / 2.0;
                    }
                    break;
                case "bus":
                    oldPeoplePrice = 32.50;
                    studentsPrice = 28.5;
                    break;
                case "boat":
                    oldPeoplePrice = 42.99;
                    studentsPrice = 39.99;
                    break;
                case "airplane":
                    oldPeoplePrice = 70.00;
                    studentsPrice = 50.00;
                    break;
            }

            double allNightPrice = 82.99 * nightsCount;

            double allMoney =  (allNightPrice + oldPeoplePrice * oldPeople * 2 + studentsPrice * students * 2);
            allMoney = allMoney + allMoney * 0.1;

            Console.WriteLine("{0:0.00}",allMoney);

        }
    }
}
