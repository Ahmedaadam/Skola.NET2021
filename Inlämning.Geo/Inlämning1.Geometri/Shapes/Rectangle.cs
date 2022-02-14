using Inlämning1.Geometri.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Geometri.Shapes
{
    public class Rectangle : IGeometricThing
    {
        public float Height { get; set; }
        public float Base { get; set; }

        public Rectangle(float height, float bas)
        {
            Height = height;
            Base = bas;
        }

        public float GetArea()
        {
            if (Height <= 0 || Base <= 0)
            {
                return 0;
            }
            else
            {
                return Height * Base;
            }
        }
        public float GetPerimeter()
        {
            if (Height <= 0 || Base <= 0)
            {
                return 0;
            }
            else
            {
                return (Height * 2) + (Base * 2);
            }
        }
    }
}
