using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning.TDD.Shapes
{
    class Square: IGeometricThings
    {
        public float Side { get; set; }

        public Square(float side)
        {
            Side = side;
        }

        public float GetArea()
        {
            if (Side <= 0) { return 0; }
            else { return (float)Math.Pow(Side, 2); }
        }

        public float GetPerimeter()
        {
            if (Side <= 0) { return 0; }
            else { return Side * 4; }
        }
    }
}
