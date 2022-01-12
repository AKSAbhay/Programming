using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the size of an array : ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.Write("Enter array elements : ");
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
