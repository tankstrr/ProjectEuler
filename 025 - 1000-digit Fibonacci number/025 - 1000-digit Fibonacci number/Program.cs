using System;
using System.Numerics;

namespace _025___1000_digit_Fibonacci_number
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
            int count = 1;
            BigInteger oldNum = 0;
            BigInteger newNum = 1;
            BigInteger tempNum = 0;
            Console.WriteLine("{0} - {1}", count, newNum);
            while (newNum.ToString().Length < 1000)
            {
                tempNum = newNum;
                newNum += oldNum;
                oldNum = tempNum;
                count++;
                Console.WriteLine("{0} - {1}", count, newNum);
            }

        }

        static void enhancedSolution()
        {
            Console.WriteLine("enhanced Solution");
        }
    }
}
