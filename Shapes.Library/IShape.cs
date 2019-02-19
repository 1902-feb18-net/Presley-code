using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    interface IShape
    {
        int Sides { get; set; }
        string Color { get; set; }

        void Give(string Shape);
        string HowManySides(string Shape);


    }
}
