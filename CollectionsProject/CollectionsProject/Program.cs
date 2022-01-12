using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Program
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Location { get; set; }
        public double Salary { get; set; }
        static void Main(string[] args)
        {
            List<Program> list = new List<Program>() { 
                new Program { ID = 1, Name = "Srinivas", Location ="Hyderabad", Salary = 8000},
                new Program{ ID = 2, Name = "Obu", Location = "Hyderabad", Salary = 12000},
                new Program{ ID = 3, Name="Ganesh", Location="Chennai", Salary = 23000},
                new Program{ ID = 4, Name = "Gopal", Location = "Ranchi", Salary = 30000}
            };
            var data = list.Where(x => x.Salary > 10000);
            foreach(var data2 in data)
            {
                Console.WriteLine(data2.ID + " " + data2.Name + " " +data2.Salary);
            }
            Console.ReadLine();
        }
    }
}
