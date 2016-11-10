using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_One
{
    class PrimerNumber
    {
        public static void printPrimerNumber()
        {
        //    int start = 2;
            int end = 100;
            int line = 1;//line number
            int count = 0;//number count
            bool flag;

            for (int start = 2; start <= end; start ++)
            {
                flag = true;//initialize
                int temp=(int)Math.Sqrt(start);
                for (int j = 2; j <= temp; j ++)
                {
                    if (0 == start % j)
                    {
                        flag = false;
                        break;
                    }
                }//end for
                if (flag)
                {
                    if (0 == line % 5)
                    {
                        line = 1;
                        Console.WriteLine("Primer:{0} ", start);
                    }
                    else
                    {
                        line++;
                        Console.Write("Primer:{0} ", start);
                    }
                    count++;
                }
            }//end for
            Console.WriteLine("\nCount Number:{0} ", count);

        }///end public 
    }
}
