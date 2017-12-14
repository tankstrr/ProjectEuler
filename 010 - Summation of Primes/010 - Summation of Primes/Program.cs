using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010___Summation_of_Primes
{
    class Program
    {
        public static void Main(string[] args)
        {
            long i, j, sum = 0;
            bool flag = true;
            for (i = 2; i < 2000000; i++)
            {
                flag = true;
                for (j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                    }
                }
                if (flag == true)
                {
                    sum = sum + i;
                }

            }

            Console.WriteLine(sum);
        }
    }
}
