namespace OopsProject
{
    using System;
    internal class Parent
    {
        public static string str = "Hello ";
        private const string str2 = ", Welcome to the Team!";
        public  string ReturnString(string name)
        {
            return str + name + str2;
        }
        public  string ReturnString(string name, bool status)
        {
            return str + name + " , Your status is " + status + " now!";
        }
       
    }
    internal class OverloadingDemo
    {
        static void Main()
        {
            Parent p = new Parent();
            var result = p.ReturnString("Abhay");
            var result2 = p.ReturnString("Abhay", true); 
            Console.WriteLine(result);
            Console.Write(result2);
            Console.ReadLine();
        }
    }
}
