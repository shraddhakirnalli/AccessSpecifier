using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.Test9
{
    class sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentense");
            string str = Console.ReadLine();
            string[] words = str.Split();
            int sum = 0;
            for (int i = 0; i < words.Length; i++)
            {
                int digit = 0, num = 0;
                char[] letter = words[i].ToCharArray();
                for (int j = 0; j < letter.Length; j++)
                {
                    if (Char.IsDigit(letter[j]))
                    {
                        digit = (int)(char.GetNumericValue(letter[j]));
                    }
                    num = num * 10 + digit;
                }
                sum = sum + num;
            }
            Console.WriteLine("Sum := " + sum);
        }
    }

    //Accept a string print following pattern
    //e.g str =”ESHAN”
    //E
    //ES
    //ESH
    //ESHA
    //ESHAN
    //ESHA
    //ESH
    //ES
    //E
    class Test9Que7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(str[j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i <= str.Length - 1; i++)
            {
                for (int j = 0; j < str.Length - i - 1; j++)
                {
                    Console.Write(str[j]);
                }
                Console.WriteLine();
            }
        }
    }




    
}




