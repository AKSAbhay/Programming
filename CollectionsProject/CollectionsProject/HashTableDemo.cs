using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class HashTableDemo
    {
        public static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Id", 1);
            ht.Add("Name", "Abhay");
            ht.Add("City","Ranchi");
            ht.Add("Designation","Software Engineer");
            ht["Name"] = "Yuvraj";
            foreach(var obj in ht.Keys)
            {
                Console.WriteLine(obj + " : " + ht[obj]);
            }
            Console.ReadLine();
        }
    }
}
