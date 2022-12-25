using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.List
{
    class ListDemo1
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            {
                2,3,4,5,6,7,8
            };
            for (int i = 0; i < li.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(li[i] + "  ");
                }
            }

        }
    }
}
