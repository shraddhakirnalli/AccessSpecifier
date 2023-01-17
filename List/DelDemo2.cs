using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.List
{
    class DelDemo2
    {
        public delegate void MyDel(string msg);
        static void CallMethod(MyDel d)
        {
            d.Invoke("Welcome to Pune............");
        }
        static void Main(string[] args)
        {
            MyDel del = Test.M1;
            DelDemo2.CallMethod(del);
        }
    }
    class Test
    {
        public static void M1(string msg)
        {
            Console.WriteLine("...................."+msg);
        }
    }
}
