using System;
class numAsWord
{
    static void Main()
    {




        int num = int.Parse(Console.ReadLine());


        if (num < 0 || num > 100)
        {
            Console.WriteLine("Invalid number");
        }
        else if (num >= 0 && num <= 12)
        {
            switch (num)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("tree");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                case 10:
                    Console.WriteLine("ten");
                    break;
                case 11:
                    Console.WriteLine("eleven");
                    break;
                case 12:
                    Console.WriteLine("twelve");
                    break;

            }
        }
        else if (num <= 19)
        {
            int number = num % 10;
            switch (number)
            {
                case 3:
                    Console.Write("thir");
                    break;
                case 4:
                    Console.Write("four");
                    break;
                case 5:
                    Console.Write("fif");
                    break;
                case 6:
                    Console.Write("six");
                    break;
                case 7:
                    Console.Write("seven");
                    break;
                case 8:
                    Console.Write("eight");
                    break;
                case 9:
                    Console.Write("nine");
                    break;

            }
            Console.WriteLine("teen");
        }
        else if (num <= 99)
        {
            int ones = num % 10;
            int tens = num / 10;

            switch (tens)
            {

                case 2:
                    Console.Write("twenty");
                    break;
                case 3:
                    Console.Write("thirty");
                    break;
                case 4:
                    Console.Write("fourty");
                    break;
                case 5:
                    Console.Write("fifty");
                    break;
                case 6:
                    Console.Write("sixty");
                    break;
                case 7:
                    Console.Write("seventy");
                    break;
                case 8:
                    Console.Write("eighty");
                    break;
                case 9:
                    Console.Write("ninety");
                    break;
            }
            switch (ones)
            {
                case 0:
                    Console.WriteLine();
                    break;
                case 1:
                    Console.WriteLine(" one");
                    break;
                case 2:
                    Console.WriteLine(" two");
                    break;
                case 3:
                    Console.WriteLine(" three");
                    break;
                case 4:
                    Console.WriteLine(" four");
                    break;
                case 5:
                    Console.WriteLine(" five");
                    break;
                case 6:
                    Console.WriteLine(" six");
                    break;
                case 7:
                    Console.WriteLine(" seven");
                    break;
                case 8:
                    Console.WriteLine(" eight");
                    break;
                case 9:
                    Console.WriteLine(" nine");
                    break;
            }

        }
        else
        {
            Console.WriteLine("one hundred");
        }




    }
}

