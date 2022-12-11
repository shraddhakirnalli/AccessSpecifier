using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier
{
    class Circle
    {
       static double PI=3.14;
        double r;
        static int c;

        public Circle()
        {
            c++;
        }
        public Circle(double pI,double r)
        {
            PI = pI;
            this.r = r;
            c++;

        }
        public static int ObjectCnt()
        {

            return c;
        }
        public double Area()
        {
            double a = PI * r * r;
            return a;
        }
    }
    class StaticVariable1
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Console.WriteLine("Object Cnt : " + Circle.ObjectCnt());
            Circle c1 = new Circle(3.14, 5.6);
            Console.WriteLine("Area of Circle : " + c1.Area());
            Console.WriteLine("Object Cnt : " + Circle.ObjectCnt());
            Circle c2 = new Circle(3.14, 4.6);
            Console.WriteLine("Area of Circle : " + c2.Area());
            Console.WriteLine("Object Cnt : " + Circle.ObjectCnt());
            Circle c3 = new Circle(3.14, 3.2);
            Console.WriteLine("Area of Circle : " + c3.Area());
            Console.WriteLine("Object Cnt : " + Circle.ObjectCnt());
        }
    }
}
