using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone obj1 = new Smartphone();
            obj1.Connect();
            obj1.Charge(30);
            obj1.Display();


            Laptop obj2 = new Laptop();
            obj2.Connect();
            obj2.Charge(60);
            obj2.Display();

            Console.ReadKey();
        }
    }
}
