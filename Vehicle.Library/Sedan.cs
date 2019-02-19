using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle.Library
{
    public class Sedan : ACar
    {
        public int passengers { get; set; } = 5;
        public override void Honk()
        {
            Console.WriteLine("Honk honk!");
        }
    }
}
