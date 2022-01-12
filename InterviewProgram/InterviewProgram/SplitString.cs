using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgram
{
    internal class SplitString
    {
        internal static void Sentence()
        {
            string str = "Abhay";
            str.Replace('a', 'A');
            Console.WriteLine(str.Remove(1));
            //var str2 = str.Substring(1,2);
            //C/*onsole.WriteLine(str2);*/
        }
        protected static void GetSubstring()
        {
            string str = "Abhay";
            for(int i = 0; i < str.Length; i++)
            {
                for(int j = 1; j <= str.Length-i; j++)
                {
                    Console.WriteLine(str.Substring(i,j));
                }
            }
        }
        public static void Main()
        {
            Sentence();
            //GetSubstring();
            Console.ReadLine();
        }
    }
}
