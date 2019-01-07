using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleManufacturingSystem.Models
{
    public class ManufactureRequest
    {
        public BicycleType type {get; set;}
        public string material {get; set;}
    }

    public enum BicycleType
    {
        Gear,
        NonGear
    }
}
