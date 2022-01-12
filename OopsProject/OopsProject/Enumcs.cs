using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    enum Cities 
    {
        Ranchi,
        Patna,
        Hyderabad,
        Banguluru
    }
    internal class Enumcs
    {
       
        public int PrintEnum()
        {
            int str = (int)Cities.Patna;
            return str;
        }
        public int PrintEnum(int i)
        {

            return 1;
        }
    }
    public class TestEnum
    {
        public static void Main()
        {
            Enumcs en = new Enumcs();
            Console.WriteLine(en.PrintEnum());
            Console.ReadLine();
        }
    }

}
