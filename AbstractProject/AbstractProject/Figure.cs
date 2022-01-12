using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    public abstract  class Figure
    {
        public  const string title = "Titkle";
        public static readonly string Name = "Abhay";
         
        static Figure()
        {
            str = "Mvc";
            Name = "Kumar Sharma"; 
            Console.WriteLine("Abstract Constructor");
        }
         ~Figure()
        {

        }
        public static string str { get; set; }
        protected double Width, Height, Radius;
        public const float Pi = 3.14f;
        public abstract double GetArea();
        public virtual void PrintString()
        {
            Console.WriteLine();
        }
    }
    public class Rectangle : Figure
    {

        public Rectangle(double Width, double Height)
        {
            //Figure.title = "Abc";
            this.Width = Width;
            this.Height = Height;   
        }
        public override double GetArea()
        {
            return Width * Height;
        }
    }
    public class Circle : Figure
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;   
        }
        public override double GetArea()
        {
            return Pi * Radius * Radius;
        }
    }
    public class Cone : Figure
    {
        public Cone(double Radius, double Height)
        {
            this.Radius = Radius;
            this.Height = Height; 
        }
        public override double GetArea()
        {
            return Pi * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
        }
    }
    class TestFigures
    {
        public static void Main()
        {
            Rectangle r = new Rectangle(12.67,58.78);
            
            Circle c = new Circle(45.67);
            Cone c1 = new Cone(34.98,12.98);
            Console.WriteLine("Area of Rectangle : "+r.GetArea());
            Console.WriteLine("Area of Circle : " + c.GetArea());
            Console.WriteLine("Area of Cone : " + c1.GetArea());
           
            Console.ReadLine();
        }
    }
}
