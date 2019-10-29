using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    class EquilateralTriangle : Polygon
    {
        public EquilateralTriangle(double side)
            : base(side) { }

        public override double GetArea()
        {
            double area = 0;
            area = (Math.Sqrt(3)/4) * side * side;
            area = Math.Round(area, 2);
            return area;
        }
    }
}
