using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoc
{
    internal class AbstractChild : AbstractParent
    {
        public override void Method1()
        {
            Console.WriteLine("Method1 is called !!");
        }
        public static void Main()
        {
            AbstractParent ac = new AbstractChild();
            ac.Method1();
            ac.Method2();
            Console.ReadLine();
        }
    }
}
