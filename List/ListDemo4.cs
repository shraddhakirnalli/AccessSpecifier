using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.List
{
    class ListDemo4
    {
        static void Main(string[] args)
        {
            SortedList<int, string> st = new SortedList<int, string>();
            st.Add(1, "Pune");
            st.Add(2, "Mumbai");
            st.Add(3, "Hyderabad");
            st.Add(4, "Delhi");
            st.Add(5, "Patna");
            foreach(var myentry in st)
            {
                if(myentry.Key%2==0)
                {
                    Console.WriteLine(myentry.Key+" "+myentry.Value);
                }
                
            }

        }
    }
}
