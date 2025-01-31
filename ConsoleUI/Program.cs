﻿using System;
using System.Collections.Generic;
using System.Linq;
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
             * Create an abstract class called Vehicle -DONE/////
             * The vehicle class shall have three string properties Year, Make, and Model-DONE/////
             * Set the defaults to something generic in the Vehicle class-DONE//////
             * Vehicle shall have an abstract method called DriveAbstract with no implementation-DONE//////
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.-DONE///////
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle -DONE///
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            var lexus = new Car() { HasSunRoof = true, Make = "Toyota", Model ="Lexus LC", Year = 2022 };
            var harley = new Motorcyle() { HasSideCar = true, Make = "Harley", Model = "Trike", Year = 2018};


            Vehicle bronco = new Car() { HasSunRoof = true, Make = "Ford", Model = "Bronco", Year = 2022 };
            Vehicle moto2 = new Motorcyle() { HasSideCar=false, Make = "Ford", Model = "hog", Year = 1972 };

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Model:{vehicle.Model}, Make:{vehicle.Make}, Year: {vehicle.Year}");

            }
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(lexus);
            vehicles.Add(harley);   
            vehicles.Add(bronco);   
            vehicles.Add(moto2);

            // Call each of the drive methods for one car and one motorcycle

            lexus.DriveAbstract();
            Console.WriteLine();
            harley.DriveAbstract();
            Console.WriteLine();
            
            bronco.DriveAbstract();
            Console.WriteLine();
            moto2.DriveAbstract();
            Console.WriteLine();
            #endregion            
            Console.ReadLine();
        }
    }
}
