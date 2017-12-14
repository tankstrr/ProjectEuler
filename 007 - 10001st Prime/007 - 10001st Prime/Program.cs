using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007___10001st_Prime
{
    class Program
    {
        public static void Main(string[] args)
        {
            int zl = 3;
            int var = 2;
            while (var <= 10001)
            {

                for (int i = 2; i < zl; i++)
                {
                    if (zl % i != 0)
                    {

                        if (i == zl - 1)
                        {
                            Console.WriteLine(var + " " + zl);
                            var++;
                        }
                        continue;
                    }

                    else
                    {
                        break;
                    }
                }
                zl++;
            }

            Console.WriteLine();
        }
    }
}
