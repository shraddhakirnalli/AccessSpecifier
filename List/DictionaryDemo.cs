using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.List
{
    
    class DictionaryDemo
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            li.Add(new string("Pink"));
            li.Add(new string("Pink"));
            li.Add(new string("Black"));
            li.Add(new string("Red"));
            li.Add(new string("Black"));
            li.Add(new string("Blue"));

            Dictionary<string, int> dm = new Dictionary<string, int>();
            for(int i=0;i<li.Count;i++)
            {
                int count = 1;
                for(int j=i+1;j<li.Count;j++)
                {
                    if(li[i]==li[j])
                    {
                        count++;
                        li.RemoveAt(j);
                        j--;
                    }
                }
                Console.WriteLine(li[i]+" "+count);
            }
            
        }
    }
}
