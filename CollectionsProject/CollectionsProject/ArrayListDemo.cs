using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class ArrayListDemo
    {
        public static void Main()
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("The capacity of ArrayList with no elements : " + al.Capacity);
            al.Add("Abhay");
            Console.WriteLine("The capacity of ArrayList after adding one element : " + al.Capacity);
            al.Add(01);
            al.Add(true);
            al.Add(20.78);
            al.Add(new StringBuilder("Abhay Kumar Sharma"));
            al.Insert(0,"Srinivas");
            
            
            Console.WriteLine("The capacity of ArrayList after adding 5th element : " + al.Capacity);
            for(int i = 0; i <= al.Count-1; i++)
            {
                Console.Write(al[i] + " ");
            }
            Console.WriteLine();
            foreach (var obj in al)
            {
                Console.WriteLine(obj);
            }
            ArrayList al2 = new ArrayList(al);
            //al2.Add("Abhay");
            Console.WriteLine("xyz" + al2.IndexOf("jjj"));
           Console.WriteLine(al2.LastIndexOf("dddd"));
            al2.RemoveAt(0);
            Console.WriteLine();
            Console.WriteLine("al2 elements are printing here : ");
            foreach (var obj in al2)
            {
                al.Remove(0);
                Console.Write(obj + " ");
            }
            Console.ReadLine();
        }
    }
}
