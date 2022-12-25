using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.List
{
    class CollectionDemo3
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            a[0] = 10;
            a[1] = 20;
            a[2] = 30;
            a[3] = 40;
            a[4] = 50;

            Console.WriteLine(string.Join(" ", a));

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", a));

        }
    }
}
