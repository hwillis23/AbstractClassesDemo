using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle  //abstract car class
    {
        //implemented properties for vehicle
        public int Year { get; set; } = 2022;
            public string Make { get; set; } = "Generic Vehicle";
        public string Model { get; set; } = "Generic Model";

        public abstract void DriveAbstract(); //no implementation

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"I'm driving my {GetType().Name} like the Jetson");

        }

    }
}

            /*
            * Create an abstract class called Vehicle-DONE
            * The vehicle class shall have three string properties Year, Make, and Model-DONE
            * Set the defaults to something generic in the Vehicle class -DONE
            * Vehicle shall have an abstract method called DriveAbstract with no implementation -DONE 
            * Vehicle shall have a virtual method called DriveVirtual with a base implementation. -DONE 
            */

 
