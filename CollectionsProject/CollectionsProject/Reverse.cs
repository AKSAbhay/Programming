using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Reverse
    {
        static void Main()
        {
            int a = 0, b = 1, c = 0;
            Console.Write("Enter the limit : ");
            int l = int.Parse(Console.ReadLine());
            Console.Write(a + " " + b);
            //for(int i = 1; i <= l; i++)
            //{
            //    c = a + b;
            //    Console.Write(" " + c);
            //    a = b;b = c;
            //}
            int i = 1;
            while (i <= l)
            {
                c = a + b;
                Console.Write(" " + c);
                a = b;
                b = c;
                i++;
            }
            Console.ReadKey();
        }
    }
}
