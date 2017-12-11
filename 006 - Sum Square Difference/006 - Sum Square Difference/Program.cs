using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006___Sum_Square_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCheck = 100;
            int sumSquare = 0;
            int squareSum = 0;
            Console.WriteLine("Number to check: {0}, numCheck");
            for (int i = 1; i <= numCheck; i++)
            {
                sumSquare = sumSquare + (i * i);
            }
            Console.WriteLine("Sum of Squares: {0}", sumSquare);

            for (int i = 1; i <= numCheck; i++)
            {
                squareSum = squareSum + i;
            }
            squareSum = squareSum * squareSum;
            Console.WriteLine("Square of Sums: {0}", squareSum);
            Console.WriteLine("");
            Console.WriteLine("    Difference: {0}", squareSum - sumSquare);

            Console.ReadKey();
        }
    }
}
