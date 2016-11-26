using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Five.model
{
    class User
    {
        public User() { }
        public User(int sex, int age, int flag, string name, string num, string className)
        {
            this.sex = sex;
            this.flag = flag;
            this.name = name;
            this.className = className;
            this.num = num;
            this.age = age;
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        private string num;
       
        public string Num
        {
            get { return num; }
            set { num = value; }
        }
        private int sex;

        public int Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private string className;

        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }
        /// <summary>
        /// 存储用户类型
        /// </summary>
        private int flag;

        public int Flag
        {
            get { return flag; }
            set { flag = value; }
        }
    }
    enum UserSexType
    {
        MALE=0x0001,FEMALE
    }
    enum UserType
    {
        ADMIN=0x0001,ORDINAL
    }
}
