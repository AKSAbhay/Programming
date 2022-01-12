using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgram
{
    internal class FindGivenChar
    {
        public void FindGivenNum()
        {
            try
            {
                Again:
                string str = "Abhay";
                Console.Write("Enter a character to find : ");
                char ch2 = Char.Parse(Console.ReadLine());
                bool flag = false;
                int i;
                for (i = 0; i < str.Length; i++)
                {
                    if (ch2 == str[i])
                    {
                        flag = true;
                        break;
                        //Console.WriteLine("The character is found at " + i);
                    }
                    //goto Print;

                }
                if (flag)
                {
                    Console.WriteLine("Found at : " + i);
                    goto Again;
                }
                else
                {
                    Console.WriteLine("Not Found!");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block Executed !");
            }
        }
        public static void Main()
        {
            FindGivenChar f = new FindGivenChar();
            f.FindGivenNum();
            Console.ReadLine();
        }
    }
}
