using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class DictionaryDemo
    {
        public static void Main()
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("ID",1);
            dic.Add("Name","Abhay");
            dic.Add("Designation","Software Engineer");
            dic.Add("Country","India");
            foreach(string obj in dic.Keys)
            {
                Console.WriteLine(obj + " " + dic[obj]);
            }
            Console.ReadKey();
        }
    }
}
