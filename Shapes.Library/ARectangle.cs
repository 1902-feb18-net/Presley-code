using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    public abstract class ARectangle : IShape
    {
        public string NameOfRec { get; set; }
        int IShape.Sides { get; set; }
        string IShape.Color { get; set; }

        void IShape.Give(string Shape)
        {
            throw new NotImplementedException();
        }

        string IShape.HowManySides(string Shape)
        {
            throw new NotImplementedException();
        }
    }
}
