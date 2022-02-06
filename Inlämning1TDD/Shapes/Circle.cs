using System;

namespace Inlämning1TDD.Shapes
{
    /// <summary>
    /// Class for Circle shape
    /// </summary>
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
