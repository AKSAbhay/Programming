using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgram
{
    internal class StringPallindrom
    {
        protected static string PallindromeString()
        {
            string str = "121";
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            string result = new string(ch);
            bool IsPallindrom = str.Equals(result, StringComparison.OrdinalIgnoreCase);
            if (IsPallindrom)
            {
                Console.WriteLine("Your string " + str + " is pallindrom !");
            }
            else
            {
                Console.WriteLine("Your string " + str + " is not pallindrom !");
            }
            return "";
        }
        public static void Main()
        {
            PallindromeString();
            Console.ReadLine();
        }
    }
}
