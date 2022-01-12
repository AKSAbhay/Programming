using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Table
    {
        static void Main()
        {
            //int n;
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " * " + i + " = " + (n * i));
            }
            Console.ReadLine();
        }
    }
}
