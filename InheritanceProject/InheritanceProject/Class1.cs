namespace InheritanceProject
{
    using System;
    internal class Class1
    {
        public int l = 0;
        public int n = 0;
        public string str = "Good";
        /*Right Angle triangle*/
        public void starPatter()
        {
            Console.WriteLine("****************Program to find the star pattern in triangular form*********");
            Console.Write("Enter the maximum number : ");
            l = int.Parse(Console.ReadLine());
            for(int i = 1; i <= l; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        /*Inverted Right Angle Triangle*/
        public void reverseStarPattern()
        {
            Console.WriteLine("****************Program to find the star pattern in triangular form in reverse******************");
            Console.Write("Enter the limit : ");
            l = int.Parse(Console.ReadLine());
            for(int i = 5; i > 0; i--)
            {
                for(int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
