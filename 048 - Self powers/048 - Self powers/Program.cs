using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _048___Self_powers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger totalSum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                BigInteger newNum;
                double power = Math.Pow(i, i);
                newNum = (BigInteger) power;
                totalSum = totalSum + newNum;
                Console.WriteLine("{0} - {1}", i, newNum);
                Console.WriteLine("Total Sum: {0}", totalSum);
            }
        }
    }
}
