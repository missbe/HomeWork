using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_One
{
    class Multiplication
    {
        public static void printMultiplication()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}  ",i,j,i*j);
                }
                Console.WriteLine();
            }
        }
    }
}
