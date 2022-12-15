using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        
        public bool sideCart { get; set; }

        public override void DriverAbstract()
        {
            Console.WriteLine("This is the over ride method from Base,   it was an empty abstract method but I can use it here"); 
        }

        public override void DriverVirtual()
        {
            Console.WriteLine("This is the  Virtual Method to motorcycle");
        }
    }
}
