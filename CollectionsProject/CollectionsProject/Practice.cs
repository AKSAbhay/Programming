using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Practice
    {
        static int x;
        static string str;
        static bool b;
        static uint x2;
        static double d;
        static float f;
        static int[] arr;
        static object obj;
        protected static void Main(string[] abc)
        {
            //string str = null;
            //int x = Convert.ToInt32(str);
            //Console.WriteLine(x);
            //string str = null;
            //Console.WriteLine(str.ToString());
            //bool b  = int.TryParse("10.9", out int n);
            //Console.WriteLine(b);
            //string str = "";
            Console.WriteLine(x);
            Console.WriteLine(str);
            Console.WriteLine(b);
            Console.WriteLine(x2);
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(arr);
            Console.WriteLine(obj);
            Main(10);
            Console.ReadLine();
        }
        static void Main(int x)
        {
            Console.WriteLine("Oveloaded Methoad.");
        }
    }
}
