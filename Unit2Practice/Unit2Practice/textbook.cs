using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit2Practice
{
    class Textbook : Books
    {
        int gradeLevel;
        public Textbook()
            : base() { }


        public override double setPrice() {
            Random hi = new Random();
            double randPrice = hi.Next(20, 81);
            return randPrice;
        }
    }
}
