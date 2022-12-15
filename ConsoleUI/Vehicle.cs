using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle //I made class called vehicles, I created 3 properties
    {
        public string Make { get; set; } = "Default Make";
        public string Year { get; set; } = "Defaults Year";
        public string Model { get; set; } = "Default Model";
        public abstract  void DriverAbstract();
        public virtual void DriverVirtual()
         {
        Console.WriteLine("  This is the default Virtual Method");
        } 
    
    }

    //Vehicle shall have an abstract method called DriveAbstract with no implementation
    //* Vehicle shall have a virtual method called DriveVirtual with a base implementation.

    
    

}
