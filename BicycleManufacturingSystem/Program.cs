
using System;

namespace BicycleManufacturingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            BicycleManufacturingCompany manufactureRequest = new BicycleManufacturingCompany();
            var manufactureResponse = manufactureRequest.Manufacture(new Models.ManufactureRequest
                                                                     {
                                                                       type="Gearless",
                                                                       material="steel"
                                                                     });
            manufactureResponse.ApplyBrake();
        }
    }
}
