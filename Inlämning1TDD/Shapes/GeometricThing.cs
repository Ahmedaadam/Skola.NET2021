namespace Inlämning1TDD.Shapes
{
    public interface IGeometricThing
    {
        /// <summary>
        /// Possible for the subclasses to inherit the method
        /// </summary>
        /// <returns>float default value</returns>
        public virtual float GetPerimeter()
        {
            return default;
        }

        /// <summary>
        /// Possible for the subclasses to inherit the method
        /// </summary>
        /// <returns>float default value</returns>
        public virtual float GetArea()
        {
            return default;
        }
    }
}
