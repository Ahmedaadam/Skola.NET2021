using Inlämning1.Geometri.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Geometri
{
    public abstract class GeoCalculator
    {
        public static float GetArea(IGeometricThing[] things)
        {
            if (things == null)
            {
                return 0;
            }
            else
            {
                if (things.Length == 1)
                {
                    foreach (var shape in things)
                    {
                        return shape.GetArea();
                    }
                }
                else if (things.Length > 1)
                {
                    var sum = 0F;
                    foreach (var shape in things)
                    {
                        sum += shape.GetArea();
                    }
                    return sum;
                }
            }
            return 0;
        }

        public static float GetPerimeter(IGeometricThing[] thing)
        {
            if (thing == null)
            {
                return 0;
            }
            else
            {
                if (thing.Length == 1)
                {
                    foreach (var shape in thing)
                    {
                        return shape.GetPerimeter();
                    }
                }
                else if (thing.Length > 1)
                {
                    var sum = 0F;
                    foreach (var shape in thing)
                    {
                        sum += shape.GetPerimeter();
                    }
                    return sum;
                }
            }
            return 0;
        }
    }
}
