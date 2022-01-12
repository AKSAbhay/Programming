using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Person
    {
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
    }
    internal class Teacher : Person
    {
        public void Method2()
        {
            Console.WriteLine("Method2");
        }
    }
    internal class Student : Teacher
    {
        public void Method3()
        {
            Console.WriteLine("Method 3");
        }
    }
    internal class Inheritance
    {
        static void Main()
        {
            Student student = new Student();
            student.Method1();
            student.Method2();
            student.Method3();
            Console.ReadLine();
        }
    }
}
