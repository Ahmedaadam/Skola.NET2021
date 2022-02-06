using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning.TDD
{
    interface IGeometricThings
    {
        /// <summary>
        /// Calcualates Perimeter.
        /// </summary>
        /// <returns>Perimeter in float.</returns>
        public abstract float GetPerimeter();
        /// <summary>
        /// Calculates Area.
        /// </summary>
        /// <returns>Area in float.</returns>
        public abstract float GetArea();
    }
}
