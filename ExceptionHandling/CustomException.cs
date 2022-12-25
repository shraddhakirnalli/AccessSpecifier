using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.ExceptionHandling
{
    class BinaryNumberException : SystemException
    {
        public BinaryNumberException()
        {
            Console.WriteLine("Invalid Binary Number");
        }
    }
    class CustomException
    {
        public static void CheckBinary(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '0' || str[i] == '1')
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            if (count != str.Length)
            {
                throw new BinaryNumberException();
            }
            else
            {
                Console.WriteLine("Valid Binary Number");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            try
            {
                CustomException.CheckBinary(str);
            }
            catch
            {
                Console.WriteLine("Handle...");
            }
        }
    }
    
}
