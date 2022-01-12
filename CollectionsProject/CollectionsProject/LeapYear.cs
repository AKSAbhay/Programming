using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class LeapYear
    {
        public void LeapYear1()
        {
            Console.WriteLine("Enter a year : ");
            int year = int.Parse(Console.ReadLine());
            if((year / 400 == 0) || (year / 4 == 0 && year / 100 != 0))
            {
                Console.WriteLine("Your Entered year " + year + " is a leap year!");
            }
            else
            {
                Console.WriteLine("Your entered year " + year + " is not a leap year !");
            }

        }
        static void Main()
        {
            LeapYear lp = new LeapYear();
            lp.LeapYear1();
            Console.ReadLine();
        }
    }
}
