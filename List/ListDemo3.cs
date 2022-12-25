using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.List
{
    class ListDemo3
    {

        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(34);
            li.Add(3);
            li.Add(7);

            var citynames = new List<string>()
            {
                "pune",
                "mumbai",
                "Bangalore",
                "nasik"
            };

            for(int i=0;i<citynames.Count;i++)
            {
                Console.WriteLine(citynames[i]);
            }
            Console.WriteLine("....................................");
            foreach(var s in citynames)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("..................................");
            citynames.ForEach(cname => Console.WriteLine(cname));
            citynames.Remove("pune");
            Console.WriteLine("....................................");
            for (int i = 0; i < citynames.Count; i++)
            {
                Console.WriteLine(citynames[i]);
            }
            Console.WriteLine("....................................");
        }
    }
}
