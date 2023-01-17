using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.List
{
    public delegate T add<T>(T param1, T param2);
    class GenericDelDemo
    {
        public static int Addition(int x,int y)
        {
            return x + y;
        }
        public static string JoinName(string fname,string lname)
        {
            return fname + " " + lname;
        }
        static void Main(string[] args)
        {
            add<int> sum = GenericDelDemo.Addition;
            Console.WriteLine(sum(6,8));

            add<string> fullname = GenericDelDemo.JoinName;
            Console.WriteLine(fullname.Invoke("Yash","Jain"));

        }
    }
}
