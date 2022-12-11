using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier
{
    class StringSum
    {
        public static void Main()
        {
            string str="Hello12 World5 Programming";
            Console.WriteLine("String is="+str);
            int sum = 0;
            foreach(char ch in str)
            {
                if (ch >= 48 && ch <= 57)
                    sum = sum + int.Parse(ch.ToString());
            }
            Console.WriteLine("Digit sum present in string is"+sum);
            Console.ReadKey();

           
            
            

            
        }
    }
}

