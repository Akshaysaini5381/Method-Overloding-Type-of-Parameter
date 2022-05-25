using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloding__Type_of_Parameter
{

    class name
    {
        public void show(int num, int num1)
        {
            Console.WriteLine(" Total number :" + (num + num1));
        }

        public void show(string Name, string Name1)
        {
            Console.WriteLine(" string :" + Name +" "+ Name1);
        }
        public void show(float x, double y)
        {
            Console.WriteLine("total :" + (x + y));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            name obj = new name();
            obj.show("hello", "hii");

            Console.ReadLine();
        }
    }
}
