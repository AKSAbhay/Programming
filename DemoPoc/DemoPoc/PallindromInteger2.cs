using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoc
{
    internal class PallindromInteger2
    {
        static void Main()
        {
            int n, r, sum = 0, temp;
            Console.Write("Enter a number : ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if(temp == sum)
            {
                Console.WriteLine("Your number " + temp + " is pallindrom !");
            }
            else
            {
                Console.WriteLine("Your number " + temp + " is not pallindrom !");
            }
            Console.ReadLine();
        }
    }
}
