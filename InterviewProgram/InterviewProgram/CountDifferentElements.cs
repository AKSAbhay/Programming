using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgram
{
    internal class CountDifferentElements
    {
        public static int FindDigitsCount()
        {
            string str = "m@1@y@1@y@m";
            char[] ch = str.ToCharArray();
            int alphabetes = 0,digit = 0, specialcharacters=0;
            for(int i = 0; i < ch.Length; i++)
            {
                bool IsChar = Char.IsLetter(ch[i]);
                bool IsDigit = Char.IsDigit(ch[i]);
                // regular expression
                // Expression grouping
                //switch (ch[i])
                //{
                //    case Char.IsLetter(ch[i]):
                //        break;
                //}
                if (IsChar)
                {
                    alphabetes++;
                }
                else if (IsDigit)
                {
                    digit++;
                }
                else
                {
                    specialcharacters++;
                }
            }
            Console.WriteLine("The no . of Alphabets are : " +alphabetes);
            Console.WriteLine("The no. of Digits are : " +digit);
            Console.WriteLine("The no. of SpecialCharacters are : "+specialcharacters);
            return 1;
        }
        
        public static void Main()
        {
            
            FindDigitsCount();
            Console.ReadLine();
        }
    }
}
