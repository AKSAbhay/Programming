using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoc
{
    internal abstract class AbstractParent
    {
        public abstract void Method1();
        public  void Method2()
        {
            Console.WriteLine("Method2 is called !!");
        }
    }
}
