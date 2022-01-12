using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    internal class LinqDemo
    {
        public static void Main()
        {
            List<int> coll1 = new List<int>() { 13, 56, 98, 24, 62, 52, 53, 83, 78 };
            var coll2 = from i in coll1 where i > 40 orderby i ascending select i;
            Console.WriteLine(String.Join(" ",coll2));
            Console.ReadLine();
        }
    }
}
