using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _058___Powerful_Digit_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start Stopwatch
            var stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start(); //added this nice stopwatch start routine 

            int aOrig = 1;
            int bOrig = 1;
            int testMax = 100;
            BigInteger maxSum = 0;
            for (int a = aOrig; a < testMax; a++)
            {
                for (int b = bOrig; b < testMax; b++)
                {
                    BigInteger c = BigInteger.Pow(a, b);
                    //Console.WriteLine("{0:D3} ^ {1:D3} = {2}, sum {3}", a, b, c, CalcSum(c));
                    if (CalcSum(c) > maxSum)
                    {
                        maxSum = CalcSum(c);
                        //Console.WriteLine("--== NEW MAX FOUND ==-- : {0}^{1} = {2}, sum {3}", a, b, c, maxSum);
                    }
                }
            }
            //Stop Startwatch
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            Console.WriteLine("=================", maxSum);
            Console.WriteLine("Max Sum = {0}", maxSum);
            Console.WriteLine("Calc Time {0}", ts);
        }

        public static BigInteger CalcSum(BigInteger num)
        {
            int length = num.ToString().Length;
            if (length == 1)
            {
                return num;
            }
            return (num % 10) + CalcSum(num / 10);
        }

    }
}
