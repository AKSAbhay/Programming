using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class IntegerPallindrom
    {
        static void Main()
        {
            int n, sum=0, reverse=0, rem;
            int temp;
            Console.Write("Enter a number : ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                rem = n % 10;
                reverse = sum * 10 + rem;
                n = n / 10;
            }
            if(n == reverse)
            {
                Console.WriteLine("Your number " + n + " is pallindrom !");
            }
        }
    }
}
