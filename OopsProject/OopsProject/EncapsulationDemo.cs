namespace OopsProject
{
    using System;
    public class EncapParent
    {
        private bool IsActive = false;
        internal void Getter()
        {
            Console.Write("Your status is : "+IsActive);
            Console.WriteLine();
        }
        internal void Setter()
        {
            IsActive = true;
            Console.Write("You have changed the value to : " + IsActive);
        }
    }
    public class EncapChild : EncapParent
    {
        

    }
    internal class EncapsulationDemo
    {
        public static void Main()
        {
            EncapParent ep = new EncapParent();
            ep.Getter();
            ep.Setter();
            Console.ReadLine();
        }
    }
}
