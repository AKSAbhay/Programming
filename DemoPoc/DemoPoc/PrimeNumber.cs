using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoc
{
    internal class PrimeNumber
    {
        // a method to find the prime number
        public void getPrime()
        {
            int n;     // a variable to take the input from users
            int count = 0;    // a variable to check whether prime or not by icrementing its value to 2.
            Console.WriteLine("Enter the digit to check prime or not : ");   // a message to ask users to input
            n = int.Parse(Console.ReadLine());        // it allows users to enter the input 
            for(int i = 1; i <= n; i++)   // iteration is being performed
            {
                if (n % i == 0)       // condition to check whther the given number is divided by 1 or it self
                {
                    count++;      // Here incrementing the count value to 2 if the given number divided successfully by 1 0r itselt
                }
                //Console.WriteLine(i);
            }
            if(count == 2)  
            {
                Console.Write("This digit " +n+ " is Prime Number !");
            }
            else
            {
                Console.Write("This digit "+n+ " is not Prime Number !");
            }
        }

        // finding star pattern in triangular form
        public void starPattern()
        {
            int i, j, l;
            Console.Write("Enter the limit : ");
            l= int.Parse(Console.ReadLine());
            for (i = 1; i <= l; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        // finding star pattern in triangular form in reverse
        public void reversePattern()
        {
            int i, j, l;
            Console.Write("Enter the limit : ");
            l = int.Parse(Console.ReadLine());
            for (i = l; i > 0; i--)
            {
                for (j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void getPrime1to100()
        {
            int count = 0;
            Console.WriteLine("Prime numbers between 1 and 100 are: ");
            Console.WriteLine("==============================================");
            for (int i = 1; i < 101; i++)
            {
                count = 0;
                if (i > 1)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            count = 1;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.Write(i + "  ");
                    }
                }
            }
        }
        public static void Main()
        {
            PrimeNumber p = new PrimeNumber(); // instantiating the instance 
            //p.getPrime();// calling the non static method by using the instance of the PrimeNumber Class
            p.starPattern();
            //p.reversePattern();
            Console.ReadLine(); // to hold the screen until any key is pressed
        }
    }
}
