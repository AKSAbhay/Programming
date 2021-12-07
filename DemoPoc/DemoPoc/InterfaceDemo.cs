using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoc
{
    internal abstract class InterfaceDemo
    {
        public abstract class Demo1
        {
            public abstract void Add(int x, int y);
            public void Sub(int x, int y)
            {
                int Sub = x - y;
                Console.WriteLine("The sub is : "+Sub);
            }
        }
        public class Demo2 : Demo1
        {
            public override void Add(int x, int y)
            {
                int addResult = x + y;
                Console.WriteLine("The Addition is : "+addResult);
            }
        }
        class Demo3
        {
            public static void Main()
            {
                Demo2 obj = new Demo2();
                obj.Add(30, 20);
                obj.Sub(30, 20);
                Console.ReadLine();
            }
        }
    }
}
