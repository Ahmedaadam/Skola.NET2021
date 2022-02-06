namespace Inlämning1TDD.Shapes
{
    /// <summary>
    /// Class for Triangle shape
    /// </summary>
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
            if (Base <= 0 || Height <= 0 )
            {
                return 0;
            }
            else
            {
                return (Base * Height)/ 2;
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
