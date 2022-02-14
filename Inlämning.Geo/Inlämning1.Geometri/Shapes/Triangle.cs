using Inlämning1.Geometri.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Geometri.Shapes
{
    public class Triangle : IGeometricThing
    {
        public float Base { get; set; }
        public float Height { get; set; }
        public float Side { get; set; }

        public Triangle(float height, float bas, float side)
        {
            Height = height;
            Base = bas;
            Side = side;
        }

        public float GetArea()
        {
            if (Base <= 0 || Height <= 0)
            {
                return 0;
            }
            else
            {
                return (Base * Height) / 2;
            }
        }

        public float GetPerimeter()
        {
            if (Base <= 0 || Height <= 0 || Side <= 0)
            {
                return 0;
            }
            else
            {
                return Base + Height + Side;
            }
        }
    }
}
