namespace OopsProject
{
    using System;
    internal class NormalClass
    {
        static NormalClass()
        {
            Console.WriteLine("\t\t\t\tHello, Welcome to My OopsConcept, " +DateTime.Now);
            Console.WriteLine("Static constructors are parameterless !");

        }
        internal  NormalClass()
        {
            Console.WriteLine("\nParameterless Constructor is called !!");
        }
        public NormalClass(string str)
        {
            Console.WriteLine(str + " from Parameterized constructor !!");
        }
        protected NormalClass(string str, bool b)
        {
            Console.WriteLine("Overloading is possible with constructor.");
        }
        private NormalClass(float f, object obj)
        {
            Console.WriteLine("Private modifier is allowed on the constructor !");
        }
        internal NormalClass(dynamic d)
        {
            Console.WriteLine("Internal modifier is allowed on the constructor !!");
        }
        public byte b = 255;
        public sbyte t = 127;
        short s;
        public ushort s2 = 234;
        public int x =-1;
        public string str;
        public char ch;
        public float f;
        public double d;
        public long  dl;
        public bool bl;
        
        //uint t=2345;
       static void Main()
       {
            NormalClass nc = new NormalClass();
            NormalClass nc2 = new NormalClass("Abhay");
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(nc.dl);
            Console.WriteLine(nc.bl);
            Console.WriteLine(nc.str);
            Console.ReadLine();
        }
    }
}
