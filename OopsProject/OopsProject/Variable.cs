using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    internal class Variable
    {
        public static byte b;
        protected static sbyte b1;
        protected static internal short s;
        internal static ushort s1;
        public static int i;
        public static uint i1;
        protected static long l;
        protected static internal ulong l1;
        protected internal static float f;
        internal static double d;
        public static decimal d1;
        public const float PI = 3.14f;
        public static readonly string str = "Abhay";
        public static char ch;
        public static int[] arr;
        public static object obj = "It can store any type of value.";
        public static dynamic k=false;
        public static bool IsActive;
        public static DateTime dt;
        

        public static void Main()
        {
            Variable v = new Variable();
            Console.WriteLine(b);
            Console.WriteLine(b1);
            Console.WriteLine(s);
            Console.WriteLine(s1);
            Console.WriteLine(i);
            Console.WriteLine(i1);
            Console.WriteLine(l);
            Console.WriteLine(l1);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(d1);
            Console.WriteLine(PI);
            Console.WriteLine(str);
            Console.WriteLine(ch);
            Console.WriteLine(obj);
            Console.WriteLine(dt.TimeOfDay.ToString());
            Console.ReadLine();
        }
    }
}
