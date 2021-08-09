using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    public static class Utils
    {
        public static double ToDegrees(this double radians)
        {
            return radians * (180 / Math.PI);
        }
    }
}
