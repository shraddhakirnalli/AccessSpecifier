using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.Queue
{
    class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(5);
            q.Enqueue(36);
            q.Enqueue(63);
            q.Enqueue(87);
            Console.WriteLine("Element in queue"+q.Count);
            foreach(var x in q)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------"+   q.Dequeue());
            foreach(var x in q)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("--------------------------"+  q.Peek());

            Console.WriteLine(q.Contains(56));
            q.Clear();
            Console.WriteLine("Element in queue="+ q.Count);
            Console.WriteLine(q.Peek());

        }
    }
}
