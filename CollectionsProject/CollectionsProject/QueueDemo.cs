using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class QueueDemo
    {
        public static void Main()
        {
            Queue q = new Queue();
            Console.WriteLine(q.Count);
            q.Enqueue("Abhay");
            q.Enqueue(false);
            q.Enqueue(3.14f);
            q.Enqueue(8294023287);
            q.Enqueue("null");
            Console.WriteLine(q.Count);
            foreach(var obj in q)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine(q.Dequeue());
            foreach(var obj in q)
            {
                Console.Write(obj + " ");
            }
            Console.ReadLine();
        }
    }
}
