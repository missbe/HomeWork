using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_One
{
    class DataType
    {
        public static void datatype()
        {
            int myInt = 3;
            short myShort = 32765;
            uint myUint = 1;
            float myFloat = 100.15f;
            double myDouble = -99;
            long myLong = 10000;
            decimal myDecimal = -1.88m;
            Console.WriteLine("myInt:{0},myShort:{1},myUint:{2},myFloat:{3}", myInt, myShort, myUint, myFloat);
            Console.WriteLine("myDouble:{0},myLong:{1},myDecimal:{2}", myDouble, myLong, myDecimal);
            Console.ReadLine();   
        }
    }
}
