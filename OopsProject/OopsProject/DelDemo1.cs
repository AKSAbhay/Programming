using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    internal class DelDemo1
    {
        public void AddNums(int x, int y, int z)
        {
            
            Console.WriteLine(x + y + z);
        }
        public static string SayHello(string name)
        {
            return "Hello " + name;
        } 
        static void Main()
        {
            DelDemo1 demo = new DelDemo1();
            CalculatorDelegate cd = demo.AddNums;
            cd(100, 50, 40);
            cd(123, 50, 50);
            SayDelegate sd = DelDemo1.SayHello;
            Console.WriteLine(sd("Abhay"));
            Console.ReadLine();
        }
    }
}
