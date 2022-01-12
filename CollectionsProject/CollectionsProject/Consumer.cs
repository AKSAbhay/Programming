using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Consumer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()=>ID + " " + Name;
        public static void Main()
        {
            Consumer c1 = new Consumer() { ID = 1, Name = "Abhay" };
            Consumer c2 = new Consumer() { ID = 2, Name = "Kumar" };
            List<Consumer> li = new List<Consumer>() { c1, c2 };
            foreach(var obj in li)
            {
                Console.WriteLine(obj);
            }
            Dictionary<string, object> dict = new Dictionary<string, object>();
            Console.ReadLine();
        }
        
    }
}
