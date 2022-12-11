using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.Test8
{
    class Occur
    {
        static void Main()
        {
            string str = "Hello World Hello";
            Console.WriteLine("Occurrence:" + Check.CheckOccurrences(str, "Hello"));
        }
    }
    public static class Check
    {
        public static int CheckOccurrences(string str1, string pattern)
        {
            int count = 0;
            int a = 0;
            while ((a = str1.IndexOf(pattern, a)) != -1)
            {
                a += pattern.Length;
                count++;
            }
            return count;
        }
    }
    class Count
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("Enter String  : ");
            str = Console.ReadLine();
            string[] words = str.Split(' ');
            Console.WriteLine("Count of words :" + words.Length);
            Console.ReadKey();
        }

    }
    class Anagram
    {
        static void Main(string[] args)
        {
              
            Console.Write("Enter first word:");
            string str1 = Console.ReadLine();
            Console.Write("Enter second word:");
            string str2 = Console.ReadLine();
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("Both the strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagrams");
            }
        }
    }
    class Descending
    {
        public static void Main()
        {
            int[] myArr = new int[10] { 98, 76, 99, 32, 77,65,50,34,29,100 };
            int i, j, temp;
            Console.Write("Elements: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0} ", myArr[i]);
            }
            for (i = 0; i < 10; i++)
            {
                for (j = i + 1; j < 10; j++)
                {
                    if (myArr[i] < myArr[j])
                    {
                        temp = myArr[i];
                        myArr[i] = myArr[j];
                        myArr[j] = temp;
                    }
                }
            }
            Console.Write("Descending order:");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0} ", myArr[i]);
            }
            Console.Write(" ");
        }
        
    }
    class Total
    {
        public static void Main()
        {
            string str;
            int alphabet, digit, specialchar, i, l;
            alphabet = digit = specialchar = i = 0;

            Console.Write("Enter the string : ");
            str = Console.ReadLine();
            l = str.Length;

            while (i < l)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alphabet++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    specialchar++;
                }

                i++;
            }

            Console.Write("Number of Alphabets in the string is : {0}\n", alphabet);
            Console.Write("Number of Digits in the string is : {0}\n", digit);
            Console.Write("Number of Special characters in the string is : {0}\n\n", specialchar);

            Console.ReadLine();
        }
    }
    class Convert
    {
        static void Main(string[] args)
        {
            string str;
            str = "TOM";
            Console.WriteLine("UpperCase : {0}", str);

            // convert to lowercase
            Console.WriteLine("Converted to LowerCase : {0} ", str.ToLower());
            Console.ReadLine();
        }
    }
    class ArrRev
    {
        static void Main()
        {
            int[] arr = { 15, 16, 17, 18 };
            
            Console.WriteLine("Original Array= ");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            
            Array.Reverse(arr);
            Console.WriteLine("Reversed Array= ");
            foreach (int j in arr)
            {
                Console.WriteLine(j);
            }
            Console.ReadLine();
        }
    }
    class Ascending
    {
        public static void Main()
        {
            int[] arr1 = new int[10] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 };
            int i, j, tmp;

            for (i = 0; i < 10; i++)
            {
                for (j = i + 1; j < 10; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.Write("Ascending Order");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write(" ");
        }

    }
    class UniqueElements
    {
        static void Main()
        {
            int[] arr = { 10,10,20,30,40,40 };
            int n = arr.Length;

            Console.WriteLine("Unique array elements: ");

            for (int i = 0; i < n; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Console.WriteLine(arr[i]);

                }
            }

            Console.ReadLine();
        }

    }
}



