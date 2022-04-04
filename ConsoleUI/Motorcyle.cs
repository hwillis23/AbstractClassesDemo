using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcyle : Vehicle
    {
        public Motorcyle()
        {

        }
        public bool HasSideCar { get; set; } = false;
        public override void DriveAbstract()
        {
            Console.WriteLine("This Motorcycle is ready to roll forward.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("I'm driving my motorcycle virtually.");
        }








    }
}
