using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.List
{
    class SortListByLength
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>()
            {
                "pavan","maharastra","my","i","india","jalgaon"
            };

            for (int i = 0; i < li.Count; i++)
            {
                for (int j = 0; j < li.Count; j++)
                {
                    if (li[i].Length < li[j].Length)
                    {
                        var temp = li[i];
                        li[i] = li[j];
                        li[j] = temp;
                    }
                    else if (li[i].Length == li[j].Length)
                    {
                        if (li[i].CompareTo(li[j]) < 1)
                        {
                            var temp = li[i];
                            li[i] = li[j];
                            li[j] = temp;
                        }
                    }
                }
            }

            li.ForEach(c => Console.WriteLine(c));


        }
    }
}
