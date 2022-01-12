using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class ListDemo
    {
        public static void Main()
        {
            List<int> li = new List<int>();
            li.Add(1);
            li.Add(10);
            li.Add(20);
            li.Add(40);
            li.Add(50);
            li.Append(60);
            li.Insert(0, 609);
            for(int i = 0; i <= li.Count-1; i++)
            {
                Console.Write(li[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
