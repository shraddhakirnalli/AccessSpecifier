using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier
{
    class Alternate
    {
        static void Main(string[] args)
        {
            string str = "hello world";
            Console.WriteLine("String is="+str);
            for(int i=0;i<str.Length;i+=2)
                Console.Write(str[i]);
            Console.WriteLine("Enter a character");
            Console.ReadKey();
        }
    }
}
