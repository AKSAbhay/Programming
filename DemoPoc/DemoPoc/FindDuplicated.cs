using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoc
{
    internal class FindDuplicated
    {
        static void Main()
        {
            string str = "abhay";
            bool IsFound = false;
            int i = 0;
            int j = 0;
            for( i =0; i < str.Length; i++)
            {
                for(j = 0+1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        IsFound = true;
                        break;
                    }
                }
            }
            if (IsFound)
            {
                Console.WriteLine("Duplicate element Found at : " +i);
            }
            else
            {
                Console.WriteLine("Duplicates Not Found !");
            }
            Console.ReadLine();
        }
    }
}
