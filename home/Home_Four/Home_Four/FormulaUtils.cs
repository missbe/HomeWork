using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Four
{
    class FormulaUtils:FormulaInterface
    {
         public double Sin(double num)
        {
            //double temp = stack.Pop();///取出栈顶元素并且移出
            //stack.Push(Math.Sin(num));
            return Math.Sin(num);
        }

        public double Cos(double num)
        {
            //double temp = stack.Pop();///取出栈顶元素并且移出
            //stack.Push(Math.Cos(num));
            return Math.Cos(num);
        }

        public double Tan(double num)
        {
            //double temp = stack.Pop();///取出栈顶元素并且移出
            //stack.Push(Math.Tan(num));
            return Math.Tan(num);
        }

        public double Ctan(double num)
        {
            //double temp = stack.Pop();///取出栈顶元素并且移出
            //stack.Push(Math.Tan(Math.Tan(num)));
            return Math.Tan(Math.Tan(num));
        }
        /// <summary>
        /// 有问题
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double XPowY(int x, int y)
        {
            //double temp = stack.Pop();///取出栈顶元素并且移出
            //stack.Push(Math.Pow(x,y));
            return Math.Pow(x, y);
        }
        /// <summary>
        /// log(num)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public double Log(double num)
        {
            return Math.Log10(num);
        }
        /// <summary>
        /// ln(num)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public double Ln(double num)
        {
            //double temp = stack.Pop();///取出栈顶元素并且移出
            //stack.Push(Math.Log10(num));
            return Math.Log10(num);
        }
        /// <summary>
        /// num!
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public double NFactorial(double num)
        {
            double sum=1;
            for(int i=0;i<(int)num;i++)
            {
                sum *= i;
            }
            return sum;
        }
        /// <summary>
        /// 1/num
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public double OneDivX(double num)
        {
            return 1.0 / num;
        }
    }

    enum FlagEnum
    {
        ADD=0x0001,SUB,MUL,DIV,MOD,
        SIN, COS, LOG, LN, TAN, CTAN, NFACTORIAL, ONEDIVX,
        EQ, CE

    }
    class FlagEnumUtils
    {
        /// <summary>
        /// 判断符号是否是公式
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public bool isFormula(FlagEnum flag)
        {
            bool resultFlag = false;
            switch (flag)
            {
                case FlagEnum.SIN:
                case FlagEnum.COS:
                case FlagEnum.LOG:
                case FlagEnum.LN:
                case FlagEnum.TAN:
                case FlagEnum.CTAN:
                case FlagEnum.NFACTORIAL:
                case FlagEnum.ONEDIVX:
                    resultFlag = true;
                    break;
                default:
                    resultFlag = false;
                    break;
            }
            return resultFlag;
        }
        /// <summary>
        /// 判断符号是否是符号
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public bool isOperator(FlagEnum flag)
        {
            bool resultFlag = false;
            switch (flag)
            {
                case FlagEnum.ADD:
                case FlagEnum.SUB:
                case FlagEnum.MUL:
                case FlagEnum.DIV:
                case FlagEnum.MOD:               
                    resultFlag = true;
                    break;
                default:
                    resultFlag = false;
                    break;
            }
            return resultFlag;
        }
    }
}
