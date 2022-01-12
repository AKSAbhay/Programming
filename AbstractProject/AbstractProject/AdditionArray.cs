using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    internal class AdditionArray
    {
         public void Find()
        {
            int[] arr = new int[] { 1, 2, 3,45,3, 45, 66, 22, 34, 22 };
            int temp = 0;
            for(int i = 0; i <= arr.Length-1; i++)
            {
                for(int j = i+1; j <= arr.Length-1; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        temp = arr[i]+arr[i];
                    }
                }
            }
            Console.WriteLine(temp);
        }
        public void ReveseString()
        {
            string str = "malayalaM";
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            string reverse = new string(ch);
            bool isPallindrome = str.Equals(reverse, StringComparison.OrdinalIgnoreCase);
            if (isPallindrome)
            {
                Console.Write("The given number is pallindrom !");
            }
            else
            {
                Console.Write("Not pallindrome !");
            }
        }
        public void NumberofAnyType()
        {
            string str = "m@1@y@l@m";
            int alphabets = 0;
            int digits = 0;
            int specialcharacters = 0;
            char[] ch = str.ToCharArray();
            for(int i = 0; i < ch.Length; i++)
            {
                var isDigit = Char.IsDigit(ch[i]);
                var isLetter = Char.IsLetter(ch[i]);
                if (isDigit)
                {
                    digits++;
                }
                else if(isLetter)
                {
                    alphabets++;
                }
                else
                {
                    specialcharacters++;
                }
            }
            Console.WriteLine("The total numbers of the digits are : "+digits);
            Console.WriteLine("The total numbers of letters are : "+alphabets);
            Console.WriteLine("The total numbers of special characters are : " + specialcharacters);
        }
        public void Factorial()
        {
            Console.WriteLine("Enter the number : ");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i = 1; i <= n; i++)
            {
                fact=fact* i;
            }
            Console.Write("The factorial of the number " +n+" is : "+fact);
        }
        static void Main()
        {
            AdditionArray ad = new AdditionArray();
            //ad.Find();
            //ad.ReveseString();
            //ad.NumberofAnyType();
            ad.Factorial();
            Console.ReadLine();
        }
    }
}
