namespace OopsProject
{
    using System;
    internal class Person
    {
        public int Id;
        internal string Name;
        protected bool IsActive;
        protected internal long Mobile_No;
    }
    internal class Student : Person
    {
    
        public Student(int Id, string Name, long Mobile_No, bool IsActive)
        {
            this.Id = Id;
            this.Name = Name;
            this.Mobile_No = Mobile_No;
            this.IsActive = IsActive;
        }
        public void StudentDetails()
        {
            Console.WriteLine("********************Student Details***************************");
            Console.WriteLine(Id + " " + Name + " " + Mobile_No + " " + IsActive);
        }
    }
    internal class Teacher : Person
    {
        public Teacher(int Id, string Name, long Mobile_No, bool IsActive)
        {
            this.Id = Id;
            this.Name = Name;
            this.Mobile_No= Mobile_No;  
            this.IsActive=IsActive;
        }
        public double salary = 1500.00;
        public string Designation = "Teacher";
        public void TeacherDetails()
        {
            Console.WriteLine("********************Teacher Details***************************");
            Console.Write(Id + " " + Name + " " + Mobile_No + " " + IsActive + " " + salary + " " + Designation);
        }
        
    }
    internal class InheritanceDemo
    {
        public static void Main()
        {
            Student s = new Student(101,"Abhay",8294567889,true);
            Teacher t = new Teacher(102,"Kumar",8210108299,true);
            s.StudentDetails();
            t.TeacherDetails();
            Console.ReadLine();
        }
    }
}
