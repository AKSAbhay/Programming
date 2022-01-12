using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoc
{
    internal class StaticNonStatic
    {
       //var s = new StringBuilder();
        public static string PrintHello()
        {
            string str = "Abhay";
            string str2 = "Hello, " + str + ", How are you ?";
            return str;
        }
        public int PrintInt(int x, int y)
        {
            int a = x;
            int b = y;
            int c = a + b;
            return c;
        }
        public void PrintVoid(string str, int i, dynamic k, object obj)
        {
            Console.WriteLine("Abhay Kumar Sharma"+str,i,k,obj);
        }
        public double PrintDouble()
        {
            //string str = "Abhay";
            double d = 24.5;
            return d;
        }
        //public long  PrintLongDouble()
        //{
        //    return 34.55;
        //}
        public static void Main()
        {
            StaticNonStatic s = new StaticNonStatic();
            s.PrintVoid("Abhay",10,'s',"Sgharma");
            Console.WriteLine(PrintHello());
            Console.WriteLine(s.PrintInt(10,20));
            Console.ReadLine();
        }
    }
}
