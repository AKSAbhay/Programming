using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    internal  class Inheritance
    {
        protected Inheritance()
        {
            Console.WriteLine("Constructor!");
        }
        protected int l;
        int fact = 1;
        public void FindFact()
        {
            Console.Write("Enter the limit : ");
            l = int.Parse(Console.ReadLine());
            for(int i = 1; i <= l; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
        public void FindFactUsingWhile()
        {
            int number;
            int fact2 = 1;
            Console.Write("Enter the limit : ");
            number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                fact2 *= number;
                number--;
            }
            Console.Write(fact2);
        }
        public void VowelOrNot()
        {
            Console.WriteLine();
            Console.Write("Enter the single character : ");
            char ch = Char.Parse(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("The given character is vowel .");
                    break;
                case 'e':
                    Console.WriteLine("The given character is Vowel.");
                    break;
                case 'i':
                    Console.WriteLine("The given character is Vowel.");
                    break;
                case 'o':
                    Console.WriteLine("The given character is Vowel.");
                    break;
                case 'u':
                    Console.WriteLine("The given character is Vowel.");
                    break;
                default:
                    Console.WriteLine("The given character is not Vowel");
                    break;

            }
        }
        public void DoWhileDemo()
        {
            int i = 0;

            do
            {
                Console.WriteLine("i = {0}", i);
                i++;

                //if (i > 5)
                //    break;

            } while (i < 10);
        }
        public void NestedDoWhile()
        {
            int i = 0;

            do
            {
                Console.WriteLine("Value of i: {0}", i);
                int j = i;

                i++;

                do
                {
                    Console.WriteLine("Value of j: {0}", j);
                    j++;
                } while (j < 2);

            } while (i < 2);
        }
    }
    internal class Inheritance2 : Inheritance
    {
        public int FindPattern()
        {
            Console.Write("Please enter the limit : ");
            l = int.Parse(Console.ReadLine());
            for(int i = 1; i <= l; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            return 1;
        }
    }
    public class Inheritance3
    {
        public static void Main()
        {
            Inheritance2 obj = new Inheritance2();
            obj.FindFact();
            obj.FindPattern();
            obj.FindFactUsingWhile();
            obj.VowelOrNot();
            obj.DoWhileDemo();
            //obj.DoWhileDemo();
            Console.ReadLine();
        }
    }
}
