using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ConAppAssignment_18
{
    public class Laptop:IConnectable,IRechargeable,IDisplayable
    {
        int charge;
        string info;
        public Laptop()
        {
            Console.WriteLine("Laptop Low Battery");
            charge = 0;
            info = "";
        }
        public int Charge(int minutes)
        {
            charge += minutes;
            return charge;
        }
        public bool Connect()
        {
            Console.WriteLine("Laptop Connected Successfully");
            return true;
        }
        public string Display()
        {
            Console.WriteLine("Charging Time: "+charge+"minutes");
            return info;
        }
    }
}
