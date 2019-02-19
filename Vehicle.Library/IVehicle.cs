using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle.Library
{
    interface IVehicle
    {
        int cylinders { get; set; }
        int doors { get; set; }

        void TurnOn();
        void Drive(string Location);
    }
}
