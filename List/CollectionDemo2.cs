using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace AccessSpecifier.List
{
    class CollectionDemo2
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList()
            {
                1,
                "Mumbai",
                'u',
                5,
                85.34,
                "Pune",
                "Goa",
                56
            };
            foreach(var x in al)
            {
                Console.WriteLine(x);
            }
            al.Remove('u');
            Console.WriteLine("..........................");
            foreach(var x in al)
            {
                Console.WriteLine(x);
            }
            al.Remove('u');
            Console.WriteLine("...................................");
            foreach(var x in al)
            {
                Console.WriteLine(x);
            }
            al.RemoveAt(0);
            Console.WriteLine("......................................");
            foreach(var x in al)
            {
                Console.WriteLine(x);
            }
            al.RemoveRange(0, 2);

            Console.WriteLine("...............Range Removed");
            foreach(var x in al)
            {
                Console.WriteLine(x);
            }
        }
    }
}
