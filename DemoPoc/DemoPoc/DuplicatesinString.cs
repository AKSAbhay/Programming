using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoc
{
    internal class DuplicatesinString
    {
        static void Main()
        {
            string str = "abhay";
            StringBuilder sb = new StringBuilder();
            string str2="";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                //str2 += str[i];
                sb.Append(str[i]);
            }
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
