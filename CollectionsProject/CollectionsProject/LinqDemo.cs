using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class LinqDemo
    {
        public static void Main()
        {
            List<int> li = new List<int>() { 10, 30, 45, 60, 60, 30 };
            List<int> li2 = new List<int>() { 10, 30, 67, 66 };
            //var result = li.Distinct();
            //var result = li.Count(s => s % 10 == 0);
            //var result = li.Agrgegate((s1,s2)=> s1 + ", "+s2);
            //Console.WriteLine(String.Join(" ",result));
            Console.Read();
        }
    }
}
