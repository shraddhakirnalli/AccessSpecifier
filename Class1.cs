using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Size");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter Array");
            for(int i=0;i<s;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            int[]even=new int[s];
           int e = 0;
            
            for(int i=0;i<s;i++)
            {
                if(arr[i]%2==0)
                {
                    even[e++] = arr[i];
                    

                }
                
            }
            Console.WriteLine("Even array : ");
            for (int i = 0; i < e; i++)
            {
                Console.Write(even[i] + " ");
            }
        }
    }
}
