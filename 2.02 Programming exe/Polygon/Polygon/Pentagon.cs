using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    class Pentagon : Polygon
    {
        public Pentagon(double side)
            : base(side) { }

        public override double GetArea()
        {
            double area = 0;
            area = 1 / 4 * (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5)) * side * side));
            area = Math.Round(area, 2);
            return area;
        }
    }
}
