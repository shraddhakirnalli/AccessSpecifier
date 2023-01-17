using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace AccessSpecifier.Test11
{
    class Q1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Sun");
            al.Add("Mon");

            for (int i = 0; i < al.Count; i++)
            {
                for (int j = i + 1; j < al.Count; j++)
                {
                    if (al[i] == al[j])
                    {
                        al[j] = null;
                    }
                }
            }
            foreach (string str in al)
            {
                Console.Write(str + "  ");
            }
        }
    }
    class Q2
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList()
            {
                "Shraddha","Shreya","india","Piyush","maharastra","Siya","my"
            };

            for (int i = 0; i < al.Count; i++)
            {
                for (int j = i + 1; j < al.Count; j++)
                {
                    if (al[i].ToString().CompareTo(al[j].ToString()) < 1)
                    {
                        var temp = al[i];
                        al[i] = al[j];
                        al[j] = temp;
                    }
                }
            }
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Q3
    {
        public static int WordPotential(string word)
        {
            string str = word.ToUpper();
            int potential = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    potential = potential + str[i] - 64;
                }
            }
            return potential;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();

            string[] words = str.Split();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (WordPotential(words[i]) > WordPotential(words[j]))
                    {
                        string temp = words[i];
                        words[i] = words[j];
                        words[j] = temp;
                    }
                }
            }
            foreach (var item in words)
            {
                Console.Write(item + "  ");
            }
        }
    }
}
