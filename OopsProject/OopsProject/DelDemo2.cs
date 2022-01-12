using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    internal class DelDemo2
    {
        static void Main()
        {
            SayDelegate sd = delegate (string name)
            {
                return "Hello " + name + ", How are you ?";
            };
            MathDelegate sd2 = (x, y) =>
            {
                Console.WriteLine(x + y);
            };
            Console.WriteLine(sd("Abhay"));
            sd2(30,50);
            Console.ReadLine();
        }
    }
}
