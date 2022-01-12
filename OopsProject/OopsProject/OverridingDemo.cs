namespace OopsProject
{
    using System;
    public class ParentDemo
    {
        public virtual void PrintHello()
        {
            Console.WriteLine("Hell World !");
        }
        public void PrintHello(int i)
        {
            Console.WriteLine("The value of i is : "+i);
        }
    }
    internal class ChildDemo : ParentDemo
    {
        public  void PrintHello(string name, object obj)
        {
            Console.WriteLine("Hello " + name + ", Welcome to the team !" + obj);
        }
        public override void PrintHello()
        {
            Console.WriteLine("Hello from the child class!");
        }
    }
    internal class OverridingDemo
    {
        public static void Main()
        {
            ChildDemo c = new ChildDemo();
            ParentDemo d = c;
            //d.PrintHello("Abhay",true);
            d.PrintHello();
            d.PrintHello(10);
            Console.ReadLine();
        }
    }
}
