using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class StackDemo
    {
        public static void Main()
        {
            Stack s = new Stack();
            Console.WriteLine("The capacity of Stack when no elements : " + s.Count);
            s.Push("Abhay");
            Console.WriteLine("The capacity of Stack after adding one element : " + s.Count);
            s.Push(true);
            s.Push(2022);
            s.Push(12.78);
            s.Push(2022);
            s.Push(12.78);
            s.Push(new StringBuilder("Abhay Kumar Sharma"));
            foreach (Object obj in s)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            s.Pop();
            foreach(object obj in s)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            s.Peek();
            foreach(object obj in s)
            {
                Console.Write(obj + " ");
            }
            Console.ReadLine();
        }
    }
}
