namespace InheritanceProject
{
    using System;
    internal class Class2 : Class1
    {
        /*Fibbonacci Program*/
        public void findFibbonacci()
        {
            Console.WriteLine("***************Fibbonacci Series Program**********************");
            int a = 0, b = 1, c = 0;
            Console.Write("Enter the limit : ");
            l = int.Parse(Console.ReadLine());
            Console.Write(a +" " +b);
            for(int i = 0; i <= l; i++)
            {
                c = a + b;
                Console.Write(" "+c +" ");
                a = b;
                b = c;
            }
            Console.WriteLine();
        }
        /* Factorial Program */
        public void findFactorial()
        {
            Console.WriteLine("********************Factorial Program**********************");
            n = int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i = 1; i<= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("The factorial value is : "+fact);
        }
        /* Factorial program using while loop*/
        public void findFact()
        {
            Console.WriteLine("*********Factorial Program using while loop************");
            int number = 0;
            int fact = 1;
            number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                fact = fact * number;
                number--;
            }
            Console.WriteLine("The factorial of {numb} is "+fact);
        }
        /*Program to find the reverse string*/
        public void reverseString()
        {
            Console.WriteLine("*********************String Reversal Program*************************");
            int length = str.Length-1;
            Console.Write(length);
            string reverse = "";
            while (length >= 0)
            {
                reverse = reverse + str[length];
                length--;
            }
            Console.WriteLine("The reversed string is : "+reverse);
        }
        /* Program to compare two string */
        public void compareString()
        {
            Console.WriteLine("****************comparing two strings*****************");
            string str1 = "goOd"; 
            string str2 = "Good";
            if(String.Equals(str1, str2,StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Both strings are same !");
            }
            else
            {
                Console.Write("Bothe strings are not same");
            }
        }
        static void Main()
        {
            Class2 c = new Class2();

            c.starPatter();
            c.findFibbonacci();
            c.reverseStarPattern();
            c.findFactorial();
            c.findFact();
            c.reverseString();
            c.compareString();
            Console.ReadLine();
        }
    }
}
