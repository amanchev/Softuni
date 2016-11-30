using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {



        int days = int.Parse(Console.ReadLine());

        int aceptedPatients = 0;
        int declinedPatients = 0;

        int doctorsCount = 7;

        for (int i = 1; i <= days; i++)
        {
            if (i%3==0 && aceptedPatients<declinedPatients)
            {
                doctorsCount++;
            }

            int patientForThisDay = int.Parse(Console.ReadLine());

            if (patientForThisDay>doctorsCount)
            {
                declinedPatients += patientForThisDay - doctorsCount;
                aceptedPatients += doctorsCount;
            }
            else
            {
                aceptedPatients += patientForThisDay;
            }


        }

        Console.WriteLine("Treated patients: {0}.",aceptedPatients);
        Console.WriteLine("Untreated patients: {0}.",declinedPatients);







    }
}

