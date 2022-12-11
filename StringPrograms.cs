using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier
{
    class StringPrograms
    {
        static void Main(string[] args)
        {
            string str = "Hello World Programming";
            Console.WriteLine("String is="+str);

            Console.WriteLine("Enter string to be Found in present string");
            string strToFound = Console.ReadLine();

            bool isPresent = str.Contains(strToFound);
            if(isPresent)
                Console.WriteLine(strToFound+"is present in str");
            else
                Console.WriteLine(strToFound+"is not present in str");
            Console.ReadKey();
        }
    }
}
