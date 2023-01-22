using System;

namespace Methods

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose the divident : ");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.Write("Choose the divisor : ");
            int divisor = Convert.ToInt32(Console.ReadLine());



            Closest(divident, divisor);

            //______________________________________________________2


            Total(9);


            //______________________________________________________3


            Console.WriteLine("Your first sentence : ");
            var first = Console.ReadLine();
            Console.WriteLine("Your second sentence : ");
            var second = Console.ReadLine();
            Longest(first, second);


        }
        static void Closest(int divident, int divisor)
        {

            int remainder = divident % divisor;
            if (remainder == divisor / 2) //// cut reqemlerde lazim olur mesele 15 / 6 | 12 ve 18 ortasidi
            {
                Console.WriteLine($"{divident}Number is in the middle");
            }
            else if (remainder <= divisor / 2)
            {
                Console.WriteLine($"Number is closer to : {divident - remainder}");

            }
            else if (remainder > divisor / 2)
            {
                Console.WriteLine($"Number is closer to : {divident + (divisor - remainder)}");

            }
            else
            {
                Console.WriteLine(divident);
            }
        }

        static void Total(int num)
        {


            int total = 0;

            while (num > 0)
            {
                total += num;
                num--;
            }

            Console.WriteLine(total);

        }


        static void Longest(string first, string second)
        {



            if (first.Length < second.Length)
            {
                Console.WriteLine("second is longer");
            }
            else if (second.Length < first.Length)
            {
                Console.WriteLine("first is longer");
            }
            else
            {
                Console.WriteLine("there are equal");
            }
        }


    }
}



