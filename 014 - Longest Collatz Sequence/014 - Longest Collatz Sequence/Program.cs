using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014___Longest_Collatz_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longest Collatz Sequence");
            Console.WriteLine("======= ======= ========");
            double checkNum = 1000000;
            int maxSteps = 0;
            int maxStepsNum = 0;
            for (int i = 1; i <= checkNum; i++)
            {
                double j = i;
                int steps = 1;
//                Console.Write("{0}", j);
                while (j > 1)
                {
                    if (j % 2 == 0)
                    {
                        j = j / 2;
                    }
                    else
                    {
                        j = (j * 3) + 1;
                    }
//                    Console.Write(" -> {0}", j);
                    steps++;
                }
//                Console.WriteLine(" ({0} steps)", steps);
                if (steps > maxSteps)
                {
                    maxSteps = steps;
                    maxStepsNum = i;
                    Console.WriteLine("{0} steps for {1}", maxSteps, maxStepsNum);
                }
                if (i % 10000 == 0)
                {
//                    Console.WriteLine("Checked {0}", i);
                }
            }
            Console.WriteLine("===============");
            Console.WriteLine("Largest Chain: {0}", maxSteps);
            Console.WriteLine("          Num: {0}", maxStepsNum);
        }
    }
}
