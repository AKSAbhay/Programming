using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgram
{
    internal class SecondLargestNumber
    {
        static void SecondLarge(int[] arr, int arr_size)
        {
            if (arr_size < 2)
            {
                Console.WriteLine("Invalid Input !");
                return;
            }
            Array.Sort(arr);
            for(int i = arr_size - 2; i >= 0; i++)
            {
                if (arr[i] != arr_size - 1)
                {
                    Console.WriteLine("The second largest number fount : "+arr[i]);
                    return;
                }
            }
            Console.WriteLine("There is no second large number!");
        }
        static void SecondSmall()
        {
            int[] arr = new int[] { 10, 40, 50, 60 };
            Array.Sort(arr);
            for(int i = 0; i <= arr.Length - 1; i++)
            {
                if(arr[0]!=arr[1])
                {
                    Console.WriteLine("Found Elements : "+arr[i]);
                    return;
                }
            }
        }
        static void Main()
        {
            SecondLarge(new int[] { 8, 8, 0, 5 }, 2);
            Console.ReadLine();
        }
    }
}
