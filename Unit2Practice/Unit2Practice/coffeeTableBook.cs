using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit2Practice
{
    class coffeeTableBook : Books
    {
        public coffeeTableBook()
            : base() { }

        public override double setPrice()
        {
            Random hi = new Random();
            double randPrice = hi.Next(35, 101);
            return randPrice;
        }
    }
}
