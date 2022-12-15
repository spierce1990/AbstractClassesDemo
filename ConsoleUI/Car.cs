using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public override void DriverAbstract()
        {
            Console.WriteLine(" This is the Abstract class that was over ride from Vehicle with keyword");
        }

        public void  DriverVirtual( )
        {
        Console.WriteLine("Declared a body because its not abstract");
        }
        public bool canSeatMoreThanTwo { get; set; }
    }
}