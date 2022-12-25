using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.List
{
    class ListTask1
    {
        
            static void Main(string[] args)
            {
                List<int> li = new List<int>()
            {
                12,78,96,45,63,17,85,74,41,86,12,14,16,11,20,40,5,7,57
            };
                li.ForEach(Lnum => Console.Write(Lnum + " "));
                Console.WriteLine();
                for (int i = 0; i < li.Count; i++)
                {
                    bool IsPrime = true;
                    for (int j = 2; j <= li[i] / 2; j++)
                    {
                        if (li[i] % j == 0)
                        {
                            IsPrime = false;
                            break;
                        }
                    }
                    if (IsPrime)
                    {
                        Console.Write(li[i] + "  ");
                    }
                }
            }
        
        // sorting of list
        class ListTask2
        {
            static void Main(string[] args)
            {
                List<int> li = new List<int>()
            {
                12,78,96,45,63,17,85,74,41,86,12,14,16,11,20,40,5,7,57
            };
                li.ForEach(Lnum => Console.Write(Lnum + " "));
                for (int i = 0; i < li.Count; i++)
                {
                    for (int j = i + 1; j < li.Count; j++)
                    {
                        if (li[i] > li[j])
                        {
                            int temp = li[i];
                            li[i] = li[j];
                            li[j] = temp;
                        }
                    }
                }
                Console.WriteLine();
                li.ForEach(Lnum => Console.Write(Lnum + " "));
            }
        }
    }
}
