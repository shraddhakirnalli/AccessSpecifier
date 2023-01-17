using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace AccessSpecifier.List
{
    class HashDemo
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Yash");
            ht.Add(2, "Pune");
            ht.Add("1223", "Mumbai");

            foreach(DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key+" "+kv.Value);
            }
            ht.Remove(1);
            Console.WriteLine("--------------------------------------------------");
            foreach (DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
            Console.WriteLine("///////////////////////////////////////////////////////");

            Dictionary<int, string> dm = new Dictionary<int, string>();
            dm.Add(5, "Red");
            dm.Add(6, "Blue");
            dm.Add(3, "Green");

            foreach(KeyValuePair<int,string>kv in dm)
            {
                Console.WriteLine(kv.Key+" "+kv.Value);
            }

            Hashtable t = new Hashtable(dm);
            Console.WriteLine("-------------------------------------");
            foreach (KeyValuePair<int, string> kv in dm)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }
}
