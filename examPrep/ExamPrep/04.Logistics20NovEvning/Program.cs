using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics20NovEvning
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double microbusLoad = 0;
            double truckLoad = 0;
            double trainLoad = 0;

            for (int i = 0; i < n; i++)
            {
                int load = int.Parse(Console.ReadLine());

                if (load <= 3)
                {
                    microbusLoad += load;
                }
                else if (load <= 11)
                {
                    truckLoad += load;
                }
                else
                {
                    trainLoad += load;
                }
            }

            double allLoads = microbusLoad + truckLoad + trainLoad;

            double results = (microbusLoad * 200 + truckLoad * 175 + trainLoad * 120) / allLoads ;

            Console.WriteLine("{0:f2}",results);

            Console.WriteLine("{0:f2}%", microbusLoad/allLoads*100);
            Console.WriteLine("{0:f2}%", truckLoad/allLoads*100);
            Console.WriteLine("{0:f2}%", trainLoad/allLoads*100);

        }
    }
}
