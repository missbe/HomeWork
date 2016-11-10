using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex one = new RealData(1,2);
            Complex two = new RealData(2, 2);
            Complex three = new RealData(3, 2);
            Complex four = new RealData(2, 3);

            Console.WriteLine("Result:"+one.complexAdd(two));
            Console.WriteLine("Result:" + two.complexSub(three));
            Console.WriteLine("Result:" + two.complexMulti(three));

            Console.WriteLine("Result【four原值】:" + four);
            Console.WriteLine("Result【four++】:" + (four++));
            Console.WriteLine("Result【four--】:" + (four--));
            Console.WriteLine("Result【four--】:" + (four--));

            Console.WriteLine("Result【three原值】:" + three);
            Console.WriteLine("Result【++three】:" + (++three));
            Console.WriteLine("Result【three--】:" + (--three));
            Console.WriteLine("Result【three--】:" + (--three));
        }
    }
}
