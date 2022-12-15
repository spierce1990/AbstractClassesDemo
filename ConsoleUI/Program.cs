using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            List<Vehicle> vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with
             * 
             * 
             */
            //This is how to write through object initializer syntax

            Car car1 = new Car() { Year = "2022", Model = "Tesla 22", Make = "Tesla", canSeatMoreThanTwo = true };
            Motorcycle motor1 = new Motorcycle() { Year = "2010", Model = "Mitsubish ultra", Make = "Mitsubishi" , sideCart = true };
            Vehicle smartVehicle = new Motorcycle() { Year = "2023", Model = "Toyota Smart", Make = "Toyota" , sideCart = true};
            Vehicle scooter = new Motorcycle() { Year = "2019", Model = "Kia Sports", Make = "KIA", sideCart = true};
            /*
             * Add the 4 vehicles to the list
             * 
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(car1);
            vehicles.Add(motor1);
            vehicles.Add(smartVehicle);
            vehicles.Add(scooter);

            foreach (var item in vehicles)
            {
                Console.WriteLine(item);
                Console.WriteLine($"{item.Year}, {item.Make}, {item.Model} ");
                item.DriverAbstract();
                item.DriverVirtual();


            } 
            }
        // Call each of the drive methods for one car and one motorcycle
       
      
        #endregion
    
        }
    }

