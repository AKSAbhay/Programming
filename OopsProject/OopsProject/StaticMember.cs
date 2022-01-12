using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    internal  class StaticDemo
    {
        public static int x = 10;
        //public int y = 20;
        //public int y = x;
        static StaticDemo()
        {
            x = 20;
            Console.WriteLine("Objects can be created in normal static method as well!");
        }
        public static void Test1()
        {
            Console.WriteLine("We can create the instance of a static class as well as cant be inherited from static class.");
        }
        public static  void Test1 (int i)
        {
            Console.WriteLine("Static methods from static can be overloaded and virtual keyword is not allowed.");
        }
        //public StaticDemo()
        //{
        //    x = 30;
        //    Console.WriteLine("Static constructors can be modified in the non static constructor. : " +x);
        //}
        public static void StaticTest()
        {
            StaticDemo sd2 = new StaticDemo();

            Console.WriteLine("Static Method.");
        }
        public void StaticTest2()
        {
            StaticDemo sd = new StaticDemo();
            StaticTest();
            Console.WriteLine("Non static method .");
        }

    }
   internal class StaticMember
    {
      
        public static void Main()
        {
            //StaticDemo sd = new StaticDemo();
            //sd.StaticTest2();
            //Console.WriteLine("Satatic values can be assigned to non static values: " +s.y);
            Console.WriteLine("Non static values can't be assigned to static variable.");
            Console.WriteLine("Static fields accept every modifier.");
            Console.ReadLine();
        }
    }
}

