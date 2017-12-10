using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001___Multiples_of_3_or_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSum = 0;
            int toCheck = 1000;
            for (int i = 1; i < toCheck; i++)
            {
                if (i % 3 == 0)
                {
                    totalSum = totalSum + i;
                }else if (i % 5 == 0)
                {
                    totalSum = totalSum + i;
                }
            }
            Console.WriteLine("Total Sum: {0}", totalSum);
            Console.ReadKey();
        }
    }
}
