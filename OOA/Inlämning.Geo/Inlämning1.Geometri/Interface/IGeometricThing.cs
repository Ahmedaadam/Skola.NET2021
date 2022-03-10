using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Geometri.Interface
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
