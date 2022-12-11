using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier
{
    class Split
    {
        static void Main(string[] args)
        {
            string str = "Hello World Programming";
            Console.WriteLine("String is="+str);
            char[] ch = new char[4];

            string[] strArr = str.Split(' ');
            Console.WriteLine("No of string present in{0} is {1}",str,strArr.Length);

            foreach(string str2 in strArr)
                Console.WriteLine(str2);

            Console.ReadKey();
        }
    }
}
