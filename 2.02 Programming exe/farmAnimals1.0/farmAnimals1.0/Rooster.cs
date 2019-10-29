using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmAnimals1._0
{
    class Rooster : FarmAnimal
    {
        public Rooster()
           : base("Rooster") { }

        public override string DoThing()
        {
            return "The rooster says cocka-doodle-doo!";
        }
    }
}
