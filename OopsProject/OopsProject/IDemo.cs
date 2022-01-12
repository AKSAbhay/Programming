namespace OopsProject
{
    using System;
    internal  interface IParent
    {
         void Add(int x, int y);
    }
    internal interface IChild : IParent
    {
        
        void Sub(int x, int y);
    }
    public class TestInterface : IParent, IChild
    {
        public void Add(int x, int y)
        {
            int c = x + y;
            Console.WriteLine("The value of c is : "+c);
        }
        public void Sub(int x, int y)
        {
            int c = x - y;
            Console.WriteLine("The value of Subtraction is : "+c);
        }
    }
    internal interface IDemo
    {

    }
    public class CallInterface
    {
        public static void Main()
        {
            TestInterface t = new TestInterface();
            t.Add(1, 2);
            t.Sub(20,10);
            Console.ReadLine();
        }
    }
}
