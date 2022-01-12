using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class StringManipulation
    {
        public static  int FactFind(int n)
        {
            //int fact = 1;
            //while (n >= 1)
            //{
            //    return n * FactFind(n - 1);
            //}
            if(n == 0)
            {
                return 1;
            }
            return n * FactFind(n-1);
            
            
        }
        static void Main()
        {
            Console.Write(FactFind(5));
            //int n, fact = 1;
            //Console.Write("Enter a number : ");
            //n = int.Parse(Console.ReadLine());
            ////for(int i = 1; i <= n; i++)
            ////{
            ////    fact = fact * i;
            ////}
            //int i = 1;
            //while (i <= n)
            //{
            //    fact = fact * i;
            //    i++;
            //}
            //Console.Write("The factorial of " + n + " is " + fact);
            Console.Read();
        }
    }
}
