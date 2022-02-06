using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning.TDD.Shapes
{
    class Rectangle: IGeometricThings
    {
        public float Height { get; set; }
        public float Width { get; set; }

        public Rectangle(float height, float width)
        {
            Height = height;
            Width = width;
        }

        public float GetArea()
        {
            if (Height <= 0 || Width <= 0) { return 0; }
            else { return Height * Width; }
        }

        public float GetPerimeter()
        {
            if (Height <= 0 || Width <= 0) { return 0; }
            else { return (Height * 2) + (Width * 2); }
        }
    }
}
