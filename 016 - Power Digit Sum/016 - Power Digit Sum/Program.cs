using System;
using System.Numerics;

namespace _016___Power_Digit_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("016 - Power Digit Sum");
            Console.Write("Choose a Solution (1-tankstrr, 2-enhanced): ");
            string pick = Console.ReadLine();
            switch (pick)
            {
                case "":
                case "1":
                    tankstrrSolution();
                    break;
                case "2":
                    enhancedSolution();
                    break;
            }
            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey();
        }

        static void tankstrrSolution()
        {
            Console.WriteLine("tankstrr Solution");
            int power = 1000;
            int result = 0;
            BigInteger number = BigInteger.Pow(2, power);
            Console.WriteLine("2^{0} = {1}", power, number);

            while (number > 0)
            {
                result += (int)(number % 10);
                number /= 10;
                Console.WriteLine("{0}  {1}", number, result);
            }
            Console.WriteLine("Result: {0}", result);
        }

        static void enhancedSolution()
        {
            Console.WriteLine("enhanced Solution");
            int power = 1000;
            int result = 0;

            BigInteger number = BigInteger.Pow(2, power);
            Console.WriteLine("2^{0} = {1}", power, number);
            Console.Write("Sum of {0} is: ", number);

            while (number > 0)
            {
                result += (int)(number % 10);
                number /= 10;
            }
            Console.WriteLine(result);
        }
    }
}
