using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {

        public Car()
        {
        }
        public bool HasSunRoof { get; set; } = true;
        public override void DriveAbstract()
        {
            Console.WriteLine("This car is ready to roll.");

        }
    }
}
