using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Two
{
    class IdentityCard
    {
        private int newLength = 18;
        private int oldLength = 15;
        /// <summary>
        /// is new idCard
        /// </summary>
        /// <param name="idCard"></param>
        /// <returns></returns>
        private bool isNewId(String idCard)
        {
            return idCard.Length == newLength ? true : false;
        }
        /// <summary>
        /// is idCard
        /// </summary>
        /// <param name="idCard"></param>
        /// <returns></returns>
        private bool isIdCard(String idCard)
        {
            Console.WriteLine("身份证号码长度验证......");

            int length = idCard.Length;
            bool flag = false;
            Console.WriteLine("身份证号码长度--{0}......",length);
            if (length == newLength  )
            {
                flag = true;
                Console.WriteLine("身份证号码是新号码......");
                
            }else if(length == oldLength)
            {
                flag = true;
                Console.WriteLine("身份证号码是旧号码......");
            }
            else
            {
                flag = false;
                Console.WriteLine("身份证长度验证错误.....");               
            }
            return flag;
        }
        

        private String conversionNewIdCard(String idCard)
        {
            Console.WriteLine("执行转换函数中ing----");
            bool flag = false;
            string card = null;
            if (oldLength == idCard.Length)
            {
                card=idCard.Insert(6, "19");//插入两位年份
                Console.WriteLine("-----执行插入年份过后的字符串【{0}】" ,card);

                char code = getCheckCode(card);
                card += code;

                Console.WriteLine("----执行转化函数，将15位身份证转化成18位中ing.....");
                Console.WriteLine("----执行插入校验码之后的字符串--{0}", card);
                flag = true;
            }

            return flag ? idCard : null;
        }


        public void printBirthdaySex(String idCard)
        {
            if (null == idCard)
            {
                Console.WriteLine("---字符串为Null，执行结束...");
                return;
            }
            if (isIdCard(idCard))
            {
                Console.WriteLine("---身份证号码长度验证通过.....");

                string card = idCard;
                if (!isNewId(idCard))
                {
                    Console.WriteLine("---15位信息--");
                    card = conversionNewIdCard(idCard);
                }
                else
                {
                    Console.WriteLine("---18位信息--");

                    char code = getCheckCode(card);
                    if (check18BirthdayAddress(card))
                    {
                        Console.WriteLine("--省份生日验证通过--");
                    }
                    else
                    {
                        Console.WriteLine("--省份生日验证未通过--执行结束");
                        return;
                    }
                    if (code == card.ElementAt(17))
                    {
                        Console.WriteLine("--18位身份证号码的校验码--{0}", code);
                        Console.WriteLine("--18位身份证号码的校验通过--");
                    }
                    else
                    {
                        Console.WriteLine("--18位身份证号码的校验失败，身份证号码不正确--");
                        return;
                    }
                   
                }
                if (isBoy(card))
                {  
                    Console.WriteLine("Sex:Boy");
                }
                else
                {
                    Console.WriteLine("Sex:Girls");
                }
            }
            else
            {
                Console.WriteLine("---身份证号码长度错误，执行结束.....");
            }

        }
        /// <summary>
        /// 得到最后检验位
        /// </summary>
        /// <param name="idCard"></param>
        /// <returns></returns>
        private char getCheckCode(String idCard)
        {
            char[] numbers = idCard.Substring(0, 16).ToCharArray();
            int[] codes = { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 };
            int sum = 0;//initalize
            int mode = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Int32.Parse(numbers[i].ToString()) * Int32.Parse(codes[i].ToString());
            }
            mode = sum % 11;
            Console.WriteLine("----求和所得:{0} ", sum);

           int[] key={0,1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
           char[] value = { '1', '0', 'X', '9', '8', '7', '6', '5', '4', '3', '2'};

           int index = 0;
           for (int i = 0; i < key.Length; i++)
           {
               if (mode == key[i])
               {
                   break;
               }
               else
               {
                   index++;
               }
           }

           char ch = value[index];
            Console.WriteLine("----模值:{0} Value:{1} Char:{2}",mode,index,ch);

          //  return value.ElementAt();
            return value[index];
        }
        /// <summary>
        /// 判断性别
        /// </summary>
        /// <param name="idCard"></param>
        /// <returns></returns>
        private bool isBoy(String idCard)
        {
            int sex=-1;

            if (null != idCard)
            {
                sex = Int16.Parse(idCard.Substring(idCard.Length-2, 1));///顺序码
                Console.WriteLine("输出顺序码---{0}",sex);                                        
            }
            else
            {
                Console.WriteLine("性别判断时字符串为空，执行结束...");
            }
             
            return sex % 2 == 0 ? false : true;
        }
        public bool check18BirthdayAddress(string Id)
        {
           
            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
            if (address.IndexOf(Id.Remove(2)) == -1)
            {
                Console.WriteLine("-----省份验证未通过.....");               
                return false;//省份验证
            }
            string birth = Id.Substring(6, 8).Insert(6, "-").Insert(4, "-");
            DateTime time = new DateTime();
            if (DateTime.TryParse(birth, out time) == false)
            {
                Console.WriteLine("-----生日验证未通过.....");
                return false;//生日验证
            }
            return true;
        }
    }
}
