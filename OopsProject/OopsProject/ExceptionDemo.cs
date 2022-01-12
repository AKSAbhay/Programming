using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    internal class ExceptionDemo
    {
        public void Add()
        {
            try
            {
                int x, y,z;
                Console.Write("Enter 1st Number : ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Enter the 2nd Number :");
                y = int.Parse(Console.ReadLine());
                z = x / y;
                Console.WriteLine("The addition value is : "+z);
                //try
                //{

                //}
                //catch(Exception ex)
                //{
                //    Console.WriteLine(ex.ToString());
                //}
                //finally
                //{
                //    Console.WriteLine("Finally block is executed.");
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block gets executed!");
            }
        }
        static void Main()
        {
            ExceptionDemo ed = new ExceptionDemo();
            ed.Add();
            Console.ReadLine();
        }
    }
}
