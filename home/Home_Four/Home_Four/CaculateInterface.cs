using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Four
{
    interface CaculateInterface
    {
        double Add();
        double Sub();
        double Div();
        double Mul();
        double Mod();
        //入栈
       double IntoStack(double num);        
        //出栈
        double OutStack();       
        //cleat
        void ClearStack();
        double Result();
    }
}
