using Inlämning1.Geometri.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Geometri.Shapes
{
    public class Circle : IGeometricThing
    {
        public float Radius { get; set; }

        public Circle(float radius)
        {
            Radius = radius;
        }
        public float GetArea()
        {
            if (Radius <= 0)
            {
                return 0;
            }
            else
            {
                return (float)Math.PI * (float)Math.Pow(Radius, 2);
            }
        }

        public float GetPerimeter()
        {
            if (Radius <= 0)
            {
                return 0;
            }
            else
            {
                return 2 * (float)Math.PI * Radius;
            }
        }
    }
}
