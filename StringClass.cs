using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier
{
    class StringClass
    {
        static void Main(string[] args)
        {
            string str = "Shruti";
            string str1 = "Shruti";

            Console.WriteLine("Ref of str : " + str.GetHashCode());
            Console.WriteLine("Ref of str1 : " + str1.GetHashCode());
            Console.WriteLine("------------------");
            str = str + " Anil";
            Console.WriteLine("Ref of str : " + str.GetHashCode());
            str = str + " Patil";
            Console.WriteLine("Ref of str : " + str.GetHashCode());
            str = str + " Is a Student";
            Console.WriteLine("Ref of str : " + str.GetHashCode());
            Console.WriteLine("-------------------");
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello!!");
            Console.WriteLine("Reference for sb := " + sb.GetHashCode());
            sb.Append(" My Name");
            sb.Append(" Is Shraddha");
            Console.WriteLine("String is := " + sb.ToString());
            Console.WriteLine("Reference is := " + sb.GetHashCode());


        }
    }
}

