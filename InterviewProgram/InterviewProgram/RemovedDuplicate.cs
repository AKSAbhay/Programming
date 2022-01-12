using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgram
{
    internal class RemovedDuplicate
    {
        public static void RemoveDuplicate()
        {
            string str = "AbhAAyyy";
            string str2 = string.Empty;
            
            for (int i = 0; i < str.Length; i++)
            {
                if (!str2.Contains(str[i]))
                {
                    str2 += str[i];
                }
            }
            Console.WriteLine(str2);
        }
        public static void RemoveDuplicate2()
        {
            string str = "Abhaay";
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < str.Length; i++)
            {
                if (!str.Contains(str[i]))
                {
                    sb.Append(str[i]);
                }
                
            }
            Console.WriteLine(sb.ToString());

        }
        public static void Main()
        {
            //RemoveDuplicate();
            RemoveDuplicate2();
            Console.ReadLine();
        }
    }
}
