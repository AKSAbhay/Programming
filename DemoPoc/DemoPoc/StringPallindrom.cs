using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoc
{
    internal class StringPallindrom
    {
        static void Main()
        {
            string str;
            Console.WriteLine("Please enter string or integer");
            str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            string str2 = new string(ch);
            bool IsPallindrom = str.Equals(str2, StringComparison.OrdinalIgnoreCase);
            if (IsPallindrom)
            {
                Console.WriteLine("Your string is pallindrom !");
            }
            else
            {
                Console.WriteLine("Your string is not pallindrom !");
            }
            Console.ReadLine();
        }
    }
}
