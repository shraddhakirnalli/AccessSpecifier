using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.List
{
    class ListDemo5
    {
        static void Main(string[] args)
        {
            SortedList<int, string> st = new SortedList<int, string>();
            st.Add(1,"Pune");
            st.Add(2, "Mumbai");
            st.Add(3, "Nasik");
            st.Add(4, "Goa");

            foreach(var myentry in st)
            {
                Console.WriteLine(myentry.Key+" "+myentry.Value);
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(st[1]);
            Console.WriteLine("--------------------------------------------------");
            st[1] = "Hyderabad";

            foreach(var myentry in st)
            {
                Console.WriteLine(myentry.Key + " " + myentry.Value);
            }
            Console.WriteLine("--------------All Keys");
            IList<int> al = st.Keys;
            foreach(var i in al)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------All Values---------------");
            IList<string> lvalue = st.Values;

            foreach(var v in lvalue)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("-----------------Delete entry-------------------");
            st.Remove(1);

            foreach(var myentry in st)
            {
                Console.WriteLine(myentry.Key+" "+myentry.Value);
            }
            Console.WriteLine("---------------"+st.ContainsKey(1));
            Console.WriteLine("------------------"+st.ContainsValue("goa"));
            Console.WriteLine(st.Count);
        }
    }
}
