using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    internal class ExceptionDemo
    {
       public static void Main()
        {
            int x = 0;
            int y = 0;
            Console.Write("Enter 1st number : ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the 2nd number : ");
            y = int.Parse(Console.ReadLine());
            int z = x / y;
            Console.WriteLine("The division value is : "+z);
            Console.ReadLine();
        }
    }
}
