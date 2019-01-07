using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleManufacturingSystem.Models
{
    public interface ICompany
    {
        Bicycle Manufacture(ManufactureRequest details);
    }
}
