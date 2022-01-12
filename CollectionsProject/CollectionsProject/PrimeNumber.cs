using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class PrimeNumber
    {
        public void Method1()
        {
            Console.Write("Please enter a number : ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            //for(int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        count++;
            //    }
            //}
            int i = 1;
            while (i <= n )
            {
                if (n % i == 0)
                {
                    count++;
                }i++;
            }
            if(count == 2)
            {
                Console.WriteLine("Your entered number " + n + " is a prime number !");
            }
            else
            {
                Console.WriteLine("Your entered number " + n + " is not a prime number !");
            }
        }
        public static void Main()
        {
            PrimeNumber pm = new PrimeNumber();
            pm.Method1();
            Console.ReadLine();
        }
    }
}
