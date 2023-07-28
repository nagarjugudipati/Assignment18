using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment_18
{
    public class Smartphone: IRechargeable, IConnectable, IDisplayable
    {
        int charge;
        string info;
        public Smartphone()
        {
            Console.WriteLine("Smartphone Low Battery");
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
            Console.WriteLine("Smartphone Connected Successfully ");
            return true;
        }
        public string Display()
        {
            Console.WriteLine("Charging Time: "+charge+"minutes \n");
            return info;
        }
    }
}
