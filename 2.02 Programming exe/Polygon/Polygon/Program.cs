using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    public abstract class Polygon
    { protected double side;
        public double Side { get { return side; } set { side = value; } }
    

    public Polygon(double sideLength) {
        side = sideLength;
    }

        abstract public double GetArea();
    
    }
}

