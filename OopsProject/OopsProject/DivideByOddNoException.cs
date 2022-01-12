using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    internal class DivideByOddNoException :ApplicationException
    {
        public override string Message
        {
            get { return "Attempted to divide by odd number "; }
        }
    }
    public class ThrowDemo
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter 1st number : ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter 2nd number : ");
                int y = int.Parse(Console.ReadLine());
                if (y % 2 > 0)
                {
                    //throw new ApplicationException("Attempted to divide by zero");
                    throw new DivideByOddNoException();
                }
                int z = x / y;
                Console.WriteLine("The result of division is " + z);
            }
            catch (DivideByOddNoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
            Console.WriteLine("End of the program!");
            Console.ReadLine();
        }
    }
}
