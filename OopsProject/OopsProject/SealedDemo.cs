using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    internal sealed class Sealed
    {
        readonly dynamic k;
        public Sealed()
        {
            Console.WriteLine("Sealed Constructor !");
        }
        public Sealed(int x)
        {
            Console.WriteLine("The value of x is : "+x);
        }
        public int x;
        public  void PrintMessage()
        {
            Console.WriteLine("Welocome to Sealed Class !");
        }
    }
    internal  class SealedDemo
    {
       static void Main()
        {
            Sealed s = new Sealed(10);
            s.x = 1;
            Console.ReadLine();
        }
    }
}
