using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Three
{
    class Complex
    {
        private double realPart;
        public double RealPart
        {
            get { return realPart; }
            set { realPart = value; }
        }

        private double imagePart;
        public double ImagePart
        {
            get { return imagePart; }
            set { imagePart = value; }
        }

        public Complex():this(0,0)
        {
        }
        public Complex(double r, double i)
        {
            this.imagePart = i;
            this.realPart = r;
        }
        public double getReal()
        {
            return this.realPart;
        }
        public double getImagin()
        {
            return this.imagePart;
        }
        public Complex complexAdd(Complex a)
        {
            return new Complex(this.realPart + a.getReal(),
                this.imagePart + a.getImagin());
        }
        public Complex complexSub(Complex a)
        {
            Complex temp = new Complex(this.RealPart - a.RealPart,
                this.ImagePart - a.getImagin());
            return temp;
        }
        public Complex complexMulti(Complex a)
        {
            return new Complex(this.realPart * a.getReal(),
                this.imagePart * a.getImagin());
        }
        public override String ToString()
        {
            if (0 == this.realPart && 0!=this.imagePart)
            {
                return this.imagePart.ToString()+"i";
            }
            else if (0 != this.realPart && 0 == this.imagePart)
            {
                return this.realPart.ToString();
            }
            else if (0 != this.realPart && 0 != this.imagePart)
            {
                if (0 < this.imagePart)
                {
                    return this.realPart.ToString() + "+" + this.imagePart.ToString() + "i";
                }
                else
                {
                    return this.realPart.ToString() + this.imagePart.ToString() + "i";
                }               
            }
            else
            {
                return "0+0i";
            }
        }
        public static Complex operator +(Complex one, Complex two)
        {

            return new Complex(one.getReal()+two.getReal(),
                one.getImagin()+two.getImagin());
        }
        public static Complex operator -(Complex one, Complex two)
        {

            return new Complex(one.getReal() - two.getReal(),
                one.getImagin() - two.getImagin());
        }
        public static Complex operator *(Complex one, Complex two)
        {

            return new Complex(one.getReal() * two.getReal(),
                one.getImagin() * two.getImagin());
        }
        public static Complex operator ++(Complex one)
        {
            return new Complex(one.RealPart += 1 ,one.ImagePart += 1);
        }
        public static Complex operator --(Complex one)
        {

            return new Complex(one.RealPart -= 1 ,one.ImagePart -= 1);
        }
    }
}
