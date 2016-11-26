using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Home_Four
{
    public partial class Caculate : Form
    {
        private CaculateInterface caculate;////用来进行计算的对象
        FlagEnum prevFlag,nextFlag;///用来保存输入符号       
        private StringBuilder numStr;///用来保存输入的字符       
        private bool flag;///第一次遇到符号不计算标识
        public Caculate()
        {
            InitializeComponent();
            numStr = new StringBuilder();
            caculate = new Caculate10();
            radioButton2.Checked = true;///默许十进制
            caculate.ClearStack();
            init();           
        }
        /// <summary>
        /// 初始化函数，对所类的东西进行初始化
        /// </summary>
        private void init()
        {
            numStr.Clear();

            text_show_caclute.Text = "0";//都默认初始化为0           

            prevFlag = nextFlag = 0;///初始化一个没有

            flag = true;            
        }

        private void Number_Btn_Click(object sender, EventArgs e)
        {
            if (numStr.ToString().Length > 0)
            {
                caculate.OutStack();//先出栈，再入栈
            }
            string text=((Button)sender).Text;
            switch (text)
            {
                case "+/-":
                    double temp = Double.Parse(text_show_caclute.Text);
                numStr.Clear();
                numStr.Append(temp < 0 ? text_show_caclute.Text
                    : "-" + text_show_caclute.Text);///附加进入这个串里   
                    break;
                case ".":
                    ///不包含小数点才加小数点
                    if (!numStr.ToString().Contains("."))
                    {
                        numStr.Clear();
                        numStr.Append("0.");
                    }                
                    break;
                case "pi":
                //    MessageBox.Show(Math.PI.ToString());
                    numStr.Append(Math.PI.ToString());
                    break;
                case "e":
                //    MessageBox.Show(Math.E.ToString() );
                    numStr.Append(Math.E.ToString());
                    break;
                default:
                    numStr.Append(text);///附加进入这个串里     
                   break;

            }           
           if(numStr.Length > 0)
              caculate.IntoStack(Double.Parse(numStr.ToString()));           
           text_show_caclute.Text = numStr.ToString();
        }      
        private void Enabled16(bool flag)
        {
            btn_16_A.Enabled = flag;
            btn_16_B.Enabled = flag;
            btn_16_C.Enabled = flag;
            btn_16_D.Enabled = flag;
            btn_16_E.Enabled = flag;            
        }
        private void Enabled10(bool flag)
        {        
            btn_2.Enabled = flag;
            btn_3.Enabled = flag;
            btn_4.Enabled = flag;
            btn_5.Enabled = flag;
            btn_6.Enabled = flag;
            btn_7.Enabled = flag;
            btn_8.Enabled = flag;
            btn_9.Enabled = flag;

        }
        private void Enabled8(bool flag)
        {
            btn_8.Enabled = flag;
            btn_9.Enabled = flag;           
        }
        private void Enabled2(bool flag)
        {
            btn_0.Enabled = flag;
            btn_1.Enabled = flag;
        }
        private void RadioButton_Click(object sender, EventArgs e)
        {
            string text = ((RadioButton)sender).Text;
           // text_show_caclute.Text = ((RadioButton)sender).Text;
            switch (text)
            {
                case "十六进制":
                    Enabled16(true);////ABCDEF用
                    Enabled10(true);////1-10全部用
                    break;
                case "十进制":
                    caculate = new Caculate10();///建立十进制的对象
                                              
                    Enabled16(false);////ABCDEF禁用
                    Enabled10(true);////1-10全部用
                    break;
                case "八进制":
                    Enabled16(false);//ABCDEF禁用
                    Enabled10(true);///1-10全部用
                    Enabled8(false);//禁用8，9
                    break;
                case "二进制":
                    Enabled16(false);//ABCDEF禁用
                    Enabled10(false);//1-10全部禁用
                    Enabled2(true);//启用0，1
                    break;
            }///end switch
        }
        //进行计算的核心函数
        private double CaculateCore(FlagEnum flag)
        {
            double result = 0;
            switch (flag)
            {
                case FlagEnum.ADD:
                    result=caculate.Add();                                       
                    break;
                case FlagEnum.SUB:
                    result = caculate.Sub();                     
                    break;
                case FlagEnum.MUL:
                    result = caculate.Mul();                   
                    break;
                case FlagEnum.DIV:
                    result = caculate.Div();                    
                    break;
                case FlagEnum.MOD:
                    result = caculate.Mod();
                    break;
                case FlagEnum.EQ:
                    result = caculate.Result();
                    init();///重新初始化
                    break;
                case FlagEnum.CE:
                    init();///重新初始化
                    result = 0;
                    break;
                default:
                    break;
            }
            ///如果下一个符号是=号，重新初始化
            if (prevFlag == FlagEnum.EQ)
            {
                init();
            }     
            return result;
        }
        /// 按下符号时进行计算
        private void Flag_mul_Click(object sender, EventArgs e)
        {
            numStr.Clear();///清空里面的东西
            double result = 0;//保存返回的结果           
            string text = ((Button)sender).Text;
            
            switch (text)
            {
                case "+":
                    nextFlag = prevFlag;///保存前一个
                    prevFlag = FlagEnum.ADD;                    
                    break;
                case "-":
                    nextFlag = prevFlag;
                    prevFlag = FlagEnum.SUB;                   
                    break;
                case "*":
                    nextFlag = prevFlag;
                    prevFlag = FlagEnum.MUL;                   
                    break;
                case "/":
                    nextFlag = prevFlag;
                    prevFlag = FlagEnum.DIV;                   
                    break;
                case "Mod":
                    nextFlag = prevFlag;
                    prevFlag = FlagEnum.MOD;                    
                    break;
                case "=":
                    nextFlag = prevFlag;
                    prevFlag = FlagEnum.EQ;                   
                    break;
                case "CE":
                    //nextFlag = prevFlag;
                    //prevFlag = FlagEnum.CE;
                    caculate.ClearStack();
                    return;///end 
                    break;
            }
            ///进行计算操作
            if (flag)
            {
                flag=false;
                return;///第一次遇到符号不操作
            }
            else
            {
                result = CaculateCore(nextFlag);
            }
            text_show_caclute.Text = "" + result;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            caculate.OutStack();///出一步栈
            text_show_caclute.Text = "" + 0;
            numStr.Clear();
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            init();///进行重新初始化
            caculate.ClearStack();       
        }      
    }
}
