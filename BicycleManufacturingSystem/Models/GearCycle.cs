using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleManufacturingSystem.Models
{
    public class GearCycle :Bicycle
    {
        public int MaximumGear { get; set; }
        public int DefaultGear { get; set; }
        public int CurrentGear { get; set; }
        public void IncreaseGear()
        {
            if (this.CurrentGear < this.MaximumGear)
            {
                CurrentGear++;
                Console.WriteLine("Gear Increased");
            }
            else
            {
                Console.WriteLine("Already at threshold gear");
            }

        }

        public void DecreaseGear()
        {
            if(this.CurrentGear > this.DefaultGear)
            {
                CurrentGear--;
                Console.WriteLine("Gear Decreased");
            }
            else
            {
                Console.WriteLine("Already at Lowest Gear");
            }
        }
    }
}
