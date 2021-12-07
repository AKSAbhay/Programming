using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoc
{
    internal class EncapsChild :EncapsParent
    {
        public static void Main()
        {
            EncapsChild p = new EncapsChild();
            p.Get();
            p.Set(40);
            Console.ReadLine();
        }
    }
}
