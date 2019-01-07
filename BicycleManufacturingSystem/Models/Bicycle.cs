using BicycleManufacturingSystem.Models.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleManufacturingSystem.Models
{
    public class Bicycle:IDrivable
    {
        public string Color { get; set;}
        public string ModelNumber { get; set;}
        public string Material { get; set; }
        public string Wheel { get; set; }
        public string HandleBar { get; set; }
        public string Bell { get; set; }
        public string Pedal { get; set; }

        //Gear as a feature vs gear as a different bicyle
        public void ApplyBrake()
        {
            Console.WriteLine("Brake Applied Successfully");
        }
        public void ApplyHorn()
        {
            Console.WriteLine("Bell Applied Successfully");
        }

        public void MoveBackWard()
        {
            Console.WriteLine("Moving in Forward Direction");
        }

        public void MoveForward()
        {
            Console.WriteLine("Moving in reverse Direction");
        }

        public void Turn()
        {
            Console.WriteLine("Turn Applied");
        }

    }
}
