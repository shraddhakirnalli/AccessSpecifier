using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier
{
    class DisplayIndex
    {


        static void Main(string[] args)
        {
            string str = "Hello My Name Is Shraddha";
            Console.WriteLine(str);

            Console.WriteLine("Enter char");
            char ch = char.Parse(Console.ReadLine());

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    Console.WriteLine("Zero Based Index Position of {0} is {1}", ch, i);
                    break;
                }
            }

        }
    }
}
        
