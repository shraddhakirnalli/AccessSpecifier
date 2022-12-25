using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.ExceptionHandling
{
    class AlphabeticException:SystemException
    {
        public AlphabeticException()
        {
            Console.WriteLine("String Contains Alphabet");
        }
    }
    class MoreThanTenDigitException:SystemException
    {
        public MoreThanTenDigitException()
        {
            Console.WriteLine("More Than 10 Digits");
        }
    }
    class CustomExceptionDemo
    {
        public static void CheckValidNum(string str)
        {
            char[] ch = str.ToCharArray();
            int cnt = 0;
            for(int i=0;i<ch.Length;i++)
            {
                if(Char.IsDigit(ch[i]))
                {
                    cnt++;
                }
                else
                {
                    throw new AlphabeticException();
                }
            }
            if(cnt==10)
            {
                Console.WriteLine("Number is Valid:");
            }
            else
            {
                throw new MoreThanTenDigitException();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();
            try
            {
                CustomExceptionDemo.CheckValidNum(str);
            }
            catch(AlphabeticException)
            {
                Console.WriteLine("Handled1.............");
            }
            catch(MoreThanTenDigitException)
            {
                Console.WriteLine("Handled2..............");
            }
        }
    }
    
}
