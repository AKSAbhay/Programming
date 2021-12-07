namespace DemoPoc
{
    using System;
    using System.Collections.Generic;

    internal class PalindromDemo
    {
        static void ReverseString(string input)
        {
            
            char[] ch = input.ToCharArray();
            Array.Reverse(ch);
            string revrse = new string(ch);
            bool isPallindrome=input.Equals(revrse,StringComparison.OrdinalIgnoreCase);
            if (isPallindrome)
            {
                Console.WriteLine("You have this " +input +" is pallindrom");
            }
            else
            {
                Console.WriteLine("You have this " + input + " is not pallindrom");
            }


        }
        public static void FindDuplicate()
        {
            string str = "m@1@y@1@m";
            char[] ch = str.ToCharArray();
            //char[] temp = new char[ch.Length];
            for(int i = 0; i < ch.Length; i++)
            {
                for(int j = i + 1; j < ch.Length; j++)
                {
                    if (ch[i] == ch[j]) {
                        Console.WriteLine(ch[i]);
                    }
                }
            }
            
        }
        public static void findNumberofAnytype()
        {
            string str = "m@1@y@1@m";
            int alphabets = 0, digits = 0, specialcharacters = 0;
            char[] ch = str.ToCharArray();
            
            for (int i = 0; i<ch.Length; i++)
            {
                var isDigit = Char.IsDigit(ch[i]);
                var isChar = Char.IsLetter(ch[i]);
                if (isDigit)
                {
                    alphabets++;
                }
                else if(isChar)
                {
                    digits++;
                }
                else
                {
                    specialcharacters++;
                }
                //if ((ch[i] >= 65 && ch[i] <= 90) || (ch[i] >= 97 && ch[i] <= 122))
                //    alphabets++;
                //else if (ch[i] >= 48 && ch[i] <= 57)
                //    digits++;
                //else
                //    specialcharacters++;

            }
            Console.WriteLine("The numbers of alphabets are : " + alphabets);
            Console.WriteLine("The numbers of digits are : " + digits);
            Console.WriteLine("The numbers of special characters are :" + specialcharacters);
        }
        static void findDuplicates()
        {

            // Initialize ifPresent as false
            bool ifPresent = false;
            string str = "m@1@y@1@m";
            char[] ch = str.ToCharArray();

            // ArrayList to store the output
            List<char> al = new List<char>();

            for (int i = 0; i < ch.Length;i++)
            {
                for (int j = i + 1; j < ch.Length;j++)
                {
                    if (ch[i]==ch[j])
                    {

                        // Checking if element is
                        // present in the ArrayList
                        // or not if present then break
                        if (al.Contains(ch[i]))
                        {
                            break;
                        }

                        // If element is not present in the
                        // ArrayList then add it to ArrayList
                        // and make ifPresent at true
                        else
                        {
                            al.Add(ch[i]);
                            ifPresent = true;
                        }
                    }
                }
            }

            // If duplicates is present
            // then print ArrayList
            if (ifPresent == true)
            {
                Console.Write("[" + al[0] + ", ");
                for (int i = 1; i < al.Count - 1; i++)
                {
                    Console.Write(al[i] + ", ");
                }
                Console.Write(al[al.Count - 1] + "]");
            }
            else
            {
                Console.Write("No duplicates present in arrays");
            }
        }
        public static void Main()
        {
            findNumberofAnytype();
            //findDuplicates();
            //FindDuplicate();
            //Console.WriteLine("Enter the input : ");
            //string str= Console.ReadLine();
            //ReverseString(str); 
            //int n, temp, sum=0, r;
            //Console.Write("Enter the number : ");
            //n = int.Parse(Console.ReadLine());
            //temp = n;
            //while (n > 0)
            //{
            //    r = n % 10;
            //    sum = (sum * 10) + r;
            //    n = n / 10;
            //}
            //if (temp == sum)
            //{
            //    Console.WriteLine("The number you have entered is pallindrom!!");
            //}
            //else
            //{
            //    Console.WriteLine("The number you have entered is not pallindrom!!");
            //}
            Console.ReadLine();
        }
    }
}
