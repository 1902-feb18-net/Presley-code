using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle.Library
{
    public abstract class ACar : IVehicle
    {
        public int cylinders { get; set; }
        public int doors { get; set; }
        string Make { get; set; }
        string Model { get; set; }

        public void Drive(string Location)
        {
            Console.WriteLine($"Driving to {Location}");
        }

        public abstract void Honk();

        public void TurnOn()
        {
            throw new NotImplementedException();
        }
    }
}
