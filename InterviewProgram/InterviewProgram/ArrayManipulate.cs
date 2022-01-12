using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgram
{
    internal class ArrayManipulate
    {
        public void FindBig()
        {
            int[] arr = new int[2];
            int temp = 0;
            Console.WriteLine("Enter the array elements : ");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int j = 0; j < arr.Length; j++)
            {
                if (arr[j] > temp)
                {
                    temp =arr[j];
                }
            }
            Console.WriteLine("The bigger element is " +temp);
        }
        public void FindSmall()
        {
            int[] arr = new int[] { 6, 7, 3, 2, };
            int temp = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < temp)
                {
                    temp = arr[i];
                }
            }
            Console.Write(temp);
            int small = arr.Min();
            Console.WriteLine(small);

        }
        public void Star()
        {
            int n;
            Console.WriteLine("Please enter the limit : ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                for(int j= 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void Star2()
        {
            int n;
            Console.WriteLine("Please enter the limit : ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = n; i >= 0; i--)
            {
                for(int j = i; j >= 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            ArrayManipulate ar = new ArrayManipulate();
            ar.Star2();
            /*ar.Star()*/;
            //ar.FindBig();
            //ar.FindSmall();
            Console.ReadLine();
        }
    }
}
