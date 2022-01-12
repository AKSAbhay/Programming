using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgram
{
    internal class ReverseString
    {
        public static string StringReverse(string name)
        {
            string str2 = name;
            StringBuilder sb = new StringBuilder();
            //char ch = str2[0];
            //char[] ch = str2.ToCharArray();
            for (int i = str2.Length - 1; i >= 0; i--)
            {
                sb.Append(str2[i]);
               
            }

            return sb.ToString();

        }
        public static void Main()
        {
            Console.Write("The Reversed string of Good is : " + StringReverse("Good"));
            Console.ReadLine();
        }
    }
}
