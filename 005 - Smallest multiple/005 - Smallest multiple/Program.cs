using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005___Smallest_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCheck = 20;
            int number = 21;
            bool noRemain = false;
            while (noRemain == false)
            {
                number++;
                int breakOut = 0;
                for (int i = 1; i <= numCheck; i++)
                {
                    //Console.WriteLine("{0} / {1} = {2} {3}", number, i, number/i, number % i);
                    if (number % i != 0)
                    {
                        breakOut++;
                    }
                }
                if (breakOut == 0) noRemain = true;
                if (number % 1000000 == 0) Console.WriteLine("Num: {0}, {1}", number, noRemain);
                //System.Threading.Thread.Sleep(500);
            }
            Console.WriteLine("Number: {0}", number);
            Console.ReadKey();
        }
    }
}
