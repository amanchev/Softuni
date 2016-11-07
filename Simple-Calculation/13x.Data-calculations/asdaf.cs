using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13x.Data_calculations
{
    class asdaf
    {
        static void Main(string[] args)
        {
            DateTime data = DateTime.ParseExact(Console.ReadLine(),"dd-MM-yyyy",CultureInfo.InvariantCulture);


            Console.WriteLine(data.AddDays(999).ToString("dd-MM-yyyy"));



            
        }
    }
}
