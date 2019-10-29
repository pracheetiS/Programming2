using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Properties
{
    class square : Polygon
    {
        public square(double side)
            : base(side) { }

        public override double GetArea()
        {
            double area = 0;
            area = side * side;
            area = Math.Round(area, 2);
            return area;
        }
    }
}
