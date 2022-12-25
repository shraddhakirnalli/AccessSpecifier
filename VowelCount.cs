using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier
{
    class VowelCount
    {
        public static void Main()
        {
            string myStr;
            int i, len, vowel_count, cons_count;
            myStr = "Shraddha";
            vowel_count = 0;
            cons_count = 0;
            
            len = myStr.Length;
            for (i = 0; i < len; i++)
            {
                if (myStr[i] == 'a' || myStr[i] == 'e' || myStr[i] == 'i' || myStr[i] == 'o' || myStr[i] == 'u' || myStr[i] == 'A' || myStr[i] == 'E' || myStr[i] == 'I' || myStr[i] == 'O' || myStr[i] == 'U')
                {
                    vowel_count++;
                }
                else
                {
                    cons_count++;
                }
            }
            Console.WriteLine("Vowels in the string:{0}",vowel_count); 
        }
    }
}

