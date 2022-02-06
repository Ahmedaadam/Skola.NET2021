using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning.TDD.Shapes
{
    class Triangle: IGeometricThings
    {
        public float Base { get; set; }
        public float Height { get; set; }

        public Triangle(float height, float bas)
        {
            Base = bas;
            Height = height;
        }

        public float GetArea()
        {
            if (Base <= 0 || Height <= 0) { return 0; }
            else { return (Base * Height) / 2; }
        }

        public float GetPerimeter()
        {
            if (Base <= 0 || Height <= 0) { return 0; }
            else { return Base + (Height * 2); }
        }
    }
}
