using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4.Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    // if row and column numbers are even, display star operator; otherwise display gap
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    else
                    {
                        if (j % 2 != 0)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
