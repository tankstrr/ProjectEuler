using System;
using System.Numerics;

namespace _020___Factorial_Digit_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("020 - Factorial Digit Sum");
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
            int number = 100;
            int origNumber = number;
            BigInteger result = 1;
            int sum = 0;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            Console.WriteLine("{0}! is {1}", origNumber, result);
            Console.Write("Sum of digits in {0} = ", result);
            while (result > 0)
            {
                sum += (int)(result % 10);
                result /= 10;
            }
            Console.WriteLine(sum);

        }

        static void enhancedSolution()
        {
            Console.WriteLine("enhanced Solution");
        }
    }
}
