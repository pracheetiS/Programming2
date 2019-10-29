using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Properties
{
    class Hexagon : Polygon
    {
        public Hexagon(double side)
            : base(side)
        { }

        public override double GetArea()
        {
            double area = 0;
            area = (3 * Math.Sqrt(3))/2 * side * side;
            area = Math.Round(area, 2);
            return area;
        }


    }
}
