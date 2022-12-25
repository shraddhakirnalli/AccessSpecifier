using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.List
{
    class ListDemo2
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            {
                1,2,3,4,5,6,7,8,9
            };
            for(int i=1;i<=li.Count;i++)
            {
                if(li.Count%i==0)
                {
                    int a = 0;
                    a++;
                    Console.WriteLine(li[i] + "  ");
                }
            }
        }
    }
}
