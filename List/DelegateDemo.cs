using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace AccessSpecifier.List
{
    public delegate void MyDelegate(string msg);
    class Employee1
    {
        public static void MyEmployee1(string str)
        {
            Console.WriteLine("Hello All"+str);
        }

    }

    class DelegateDemo
    {
        static void Main(string[] args)
        {
            MyDelegate del = Employee1.MyEmployee1;
            del("In TQ");
        }
    }
}
