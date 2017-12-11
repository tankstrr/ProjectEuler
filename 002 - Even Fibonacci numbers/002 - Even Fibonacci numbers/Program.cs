using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002___Even_Fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int oldNum = 1;
            int newNum = 2;
            int totalEven = 0;
            Console.WriteLine("Num: {0}", oldNum);
            while (newNum < 4000000)
            {
                bool isEven = false;
                if (newNum % 2 == 0)
                {
                    totalEven = totalEven + newNum;
                    isEven = true;
                }
                Console.WriteLine("Num: {0}, {1}", newNum, isEven);
                int tempNum = oldNum;
                oldNum = newNum;
                newNum = tempNum + newNum;
            }

            Console.WriteLine("");
            Console.WriteLine("Sum: {0}", totalEven);
        }
    }
}
