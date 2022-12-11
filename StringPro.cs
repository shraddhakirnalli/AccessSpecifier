using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier
{
    class StringPro
    {
        static void Main(string[] args)
        {
            string str = "hello";
            Console.WriteLine("String is="+str);
            int len = 0;
            foreach(char ch in str)
            {
                Console.Write(ch);
                len++;
            }
            Console.WriteLine();
            Console.WriteLine("String length is"+len);
            Console.ReadKey();
        }
    }
}
