using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgram
{
    internal  class RefOut
    {
        public static void RefDemo(out int x)
        {
            x = 0;
            x = x + 10;
            //Console.WriteLine(x);
        }
        static void Main()
        {
            int y = 20;
            RefDemo(out y);
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
