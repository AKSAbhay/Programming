namespace OopsProject
{
    using System;
    internal class ConstructorDemo
    {
        static ConstructorDemo()
        {
            Console.WriteLine("Static constructor is parameterless which does not accept any modifiers and used to initialize static members of the class.");
        }
        ConstructorDemo()
        {
            Console.WriteLine();
            Console.WriteLine("By default, every class contains a default implicit constructor if we fail to define a constructor explicitly.");
        }
        public ConstructorDemo(int i)
        {
            Console.WriteLine();
            Console.WriteLine("Constructor can be overloaded !");
        }
        protected ConstructorDemo(int x, string str)
        {
            Console.WriteLine();
            Console.WriteLine("Constructor accepts every modifier!");
        }
        protected internal ConstructorDemo(string str, int x)
        {
            Console.WriteLine();
            Console.WriteLine("Protected internal modifier is also allowed !");
        }

        internal ConstructorDemo(dynamic k, object obj)
        {
            Console.WriteLine();
            Console.WriteLine("Unamed instance can also be created and Var keyword is not used as a parameter for a method or a constructor!");
        }
        public static void Main()
        {
            ConstructorDemo cd = new ConstructorDemo();
            ConstructorDemo cd2 = new ConstructorDemo(10);
            new ConstructorDemo(10,"Abhay");
            ConstructorDemo cd3;
            cd3 = new ConstructorDemo("Welcome","Abhay");
            Console.ReadLine();
        }
    }
}
