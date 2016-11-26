using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Home_Four
{
    class Caculate10 : CaculateInterface
    {
        private Stack<double> stack;
        public Caculate10()
        {
            stack = new Stack<double>();
            init();
        }
        private void init()
        {
            stack.Clear();
            stack.Push(0);///默认0在栈里
        }
        /// <summary>
        /// 当前栈顶元素加上传入参数的值重新入栈
        /// </summary>
        /// <param name="num">要进行相加的参数</param>
        /// <returns>返回相加后的和</returns>
        public double Add()
        {
            double temp_one, temp_two;            
            temp_one = !isEmpty() ? temp_one= stack.Pop() : 0;
            temp_two = !isEmpty() ? temp_two = stack.Pop() : 0;
            
            double sum = temp_one + temp_two;
            stack.Push(sum);///将结果PUSH入栈中
            return sum;
        }
        /// <summary>
        /// 当前栈顶元素的值减去值重新入栈
        /// </summary>       
        /// <returns>返回重新入栈的值</returns>
        public double Sub()
        {
            double temp_one, temp_two;
            temp_one = !isEmpty() ? temp_one = stack.Pop() : 0;
            temp_two = !isEmpty() ? temp_two = stack.Pop() : 0;

            double sum = temp_two - temp_one;
            stack.Push(sum);///将结果PUSH入栈中
            return sum;
        }
       
        public double Div()
        {
            double temp_one, temp_two;
            temp_one = !isEmpty() ? temp_one = stack.Pop() : 0;
            temp_two = !isEmpty() ? temp_two = stack.Pop() : 0;

            double sum = temp_two / temp_one;
            stack.Push(sum);///将结果PUSH入栈中
            return sum;
        }
        
        public double Mul()
        {
            double temp_one, temp_two;
            temp_one = !isEmpty() ? temp_one = stack.Pop() : 0;///取出栈顶元素并且移出
            temp_two = !isEmpty() ? temp_two = stack.Pop() : 0;
          
            double sum = temp_two * temp_one;
            stack.Push(sum);///将结果PUSH入栈中
            return sum;
        }
        /// <summary>
        /// 取余后值重新入栈
        /// </summary>       
        /// <returns>返回操作后重新入栈的值</returns>
        public double Mod()
        {
            double temp_one, temp_two;
            temp_one = !isEmpty() ? temp_one = stack.Pop() : 0;///取出栈顶元素并且移出
            temp_two = !isEmpty() ? temp_two = stack.Pop() : 0;

            double sum = temp_two % temp_one;
            stack.Push(sum);///将结果PUSH入栈中
            return sum;
        }
        //入栈
        public double IntoStack(double num)
        {
            stack.Push(num);
            return stack.Peek();
        }
       //出栈
        public double OutStack()
        {
            return !isEmpty() ? stack.Pop() : 0;
        }
        //cleat
        public void ClearStack()
        {
            init();
        }
        public double Result()
        {
            return stack.Peek();
        }

        private bool isEmpty()
        {
            return stack.Count == 0 ? true : false;
        }
    }
}
