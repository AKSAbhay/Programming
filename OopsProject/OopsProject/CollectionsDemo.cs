using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    internal class CollectionsDemo
    {
        public void StackDemo()
        {
            Stack s = new Stack();
            s.Push("1");
            s.Push("David");
            s.Push("Developer");
            s.Push("India");
            foreach(var item in s)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(s.Pop());
            Console.WriteLine();
            foreach(object obj in s)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            Console.WriteLine(s.Peek());
            foreach(object obj in s)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine("\n" + "The count is : " +s.Count);
            s.Clear();
            Console.WriteLine("\n" + "The count is : " + s.Count);
           
        }
        public void QueueDemo()
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue("Smith");
            q.Enqueue("Testing");
            q.Enqueue(true);
            q.Enqueue(3.14f);
            foreach(var item in q)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n" + q.Dequeue());
            foreach(object obj in q)
            {
                Console.Write(obj + " ");
            }
        }
        public void ArrayListDemo()
        {
            ArrayList al = new ArrayList();
            //initial capacity of arraylist
            Console.WriteLine("The initial capacity : " + al.Capacity);
            al.Add("David");
            //checking capacity after adding an element 
            Console.WriteLine("The capacity after adding an element : " + al.Capacity);
            al.Add("Austrailia");
            al.Add(true);
            al.Add(25000.00);
            al.Add(8990909000);
            //Checking the capacity after adding four elements
            Console.WriteLine("The capacity after adding fifth elements : " + al.Capacity);
            for(int i = 0; i < al.Count; i++)
            {
                Console.Write(al[i] + " ");
            }
            Console.WriteLine();
            al.Remove(true);
            for (int i = 0; i < al.Count; i++)
            {
                Console.Write(al[i] + " ");
            }
            Console.WriteLine();
            al.Insert(2, true);
            for (int i = 0; i < al.Count; i++)
            {
                Console.Write(al[i] + " ");
            }
        }
        public void HashTableDemo()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Name", "Smith");
            ht.Add("Address", "Ranchi");
            ht.Add("Status",true);
            foreach(var key in ht.Keys)
            {
                Console.WriteLine(key + ":" + ht[key]);
            }
        }
        static void Main()
        {
            CollectionsDemo cd = new CollectionsDemo();
            //cd.StackDemo();
            //cd.QueueDemo();
            //cd.ArrayListDemo();
            cd.HashTableDemo();
            Console.ReadLine();
        }
    }
}
