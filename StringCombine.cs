using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier
{
    class StringCombine
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";

            string str = "";
            foreach (char ch in str1)
                str = str + ch;

            foreach (char ch in str2)
                str = str + ch;

            Console.WriteLine("Concatinated string is" + str);
            Console.ReadKey();
        }
    }
    class StringProgram2
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";
            string str3 = "Programming";

            string[] strArr = new string[3];
            strArr[0] = str1;
            strArr[1] = str2;
            strArr[2] = str3;

            //string str=string.Concat(strArr)
            string str = str1 + str2 + str3;

            Console.WriteLine("Concatinated string is" + str);
            Console.ReadKey();
        }
        class IndexofMethod
        {
            static void Main(string[] args)
            {
                string str = "Hello World Programming";
                string str1 = "World";

                int position = str.IndexOf(str1);
                Console.WriteLine("string {0} is present at {1} location", str1, position);
                Console.ReadKey();

            }

            class CompareMethod
            {
                static void Main(string[] args)
                {
                    string str1 = "Hello";
                    string str2 = "World";

                    int comparison = string.Compare(str1, str2);

                    if (comparison == 0)
                        Console.WriteLine("Both the strings are equal");
                    else
                        if (comparison < 0)
                        Console.WriteLine("less than 0 first string precedes thebsecond string in sort order");
                    else
                        Console.WriteLine("greater than 0 first string follows the second string in sort order");
                    Console.ReadKey();



                }
            }



        }
    }
}

    /*class Copy
    {
        static void Main(string[] args)
        {
            string str1 = "Hello World";
            char[] str2 = new char[30];

            str2 = string.Copy(str1);

            Console.WriteLine("Copied string is" + str2);
            str1.CopyTo(3, str2, 3, 5);
            Console.ReadKey();
        }
    }
}*/
