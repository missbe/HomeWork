using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Three
{
    class RealData:Complex
    {
        public RealData()
        { 
        }
        public RealData(double r, double i)
        {
            base.RealPart = r;
            base.ImagePart = i;
        }
    }
}
