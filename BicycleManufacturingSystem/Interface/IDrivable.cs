using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleManufacturingSystem.Models.Interface
{
    public interface IDrivable
    {
        void ApplyBrake();
        void Turn();
        void ApplyHorn();
        void MoveForward();
        void MoveBackWard();

    }
}
