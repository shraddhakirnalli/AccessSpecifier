using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace AccessSpecifier.List
{
    class CollectionTest1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            al.Add("Pune");
            al.Add(89.56);
            al.Add(90);
            al.Add('t');

            Console.WriteLine(al.Count);
            for (int i=0;i<al.Count;i++)
            {
                Console.WriteLine(al[i]);
            }
            Console.WriteLine("---------------------------");
            foreach(var x in al)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(al[1]);

            al.Insert(1, "Goa");
            Console.WriteLine("-------------------");
            foreach(var x in al)
            {
                Console.WriteLine(x);
            }

        }
    }
}
