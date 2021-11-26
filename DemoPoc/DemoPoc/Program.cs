using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoc
{
    internal class Program
    {
        public static object BinarySearch(int[] inputArray, int key, int min, int max)
        {
            if (min > max)
            {
                return "Nil";
            }
            else
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    return BinarySearch(inputArray, key, min, mid - 1);
                }
                else
                {
                    return BinarySearch(inputArray, key, mid + 1, max);
                }
            }
        }
        public void FindLeapYear()
        {
            Console.Write("Enter the year : ");
            int year = int.Parse(Console.ReadLine());
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine("Your year is a leap year.");
            }
            else
            {
                Console.WriteLine("Your year is not a leap year.");
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            object obj = BinarySearch(new int[] {6,7,8,9,10} ,6, 0, 4);
            Console.Write(obj);
            Console.ReadLine();
        }
    }
}
