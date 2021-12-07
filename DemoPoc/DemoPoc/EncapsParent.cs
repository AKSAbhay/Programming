using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoc
{
    internal class EncapsParent
    {
        private int x;
        public void Get()
        {
            Console.WriteLine("The value of x is :"+x);
        }
        public void Set(int y)
        {
            x = y;
            Console.WriteLine("The value of x is :"+x);
        }
    }
}
