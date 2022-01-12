using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgram
{
    internal class SingleDuplicateChar
    {
        
             
        public string findDuplicate()
        {
            Console.Write("Enter the string : ");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            string result = "";
            for(int i = 0; i < ch.Length; i++)
            {
                for(int j = i+1; j < ch.Length; j++)
                {
                    if (ch[i] == ch[j])
                    {
                        result += ch[i].ToString();
                    }
                }
                //Console.WriteLine(" " +result);
            }
            Console.WriteLine(" " + result);
            return "";
        }
        static void Main()
        {
            SingleDuplicateChar p = new SingleDuplicateChar();
            p.findDuplicate();
            Console.ReadLine();
        }
    }
}
