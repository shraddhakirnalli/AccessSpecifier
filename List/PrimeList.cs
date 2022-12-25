using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.List
{
    class PrimeList
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            {
                12,7,9,35,67,72,31,9
            };
            li.ForEach(Lnum => Console.WriteLine(Lnum + " "));
            Console.WriteLine();
            for(int i=0;i<li.Count;i++)
            {
                bool isPrime = true;
                for(int j=2;j<=li[i]/2; j++)
                {
                    if(li[i]%j==0)
                    {
                        isPrime = false;
                        break;

                    }
                }
                if(isPrime)
                {
                    Console.WriteLine(li[i]+" ");
                }
            }
        }
    }
}
