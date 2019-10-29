using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmAnimals1._0
{
    class Cow : FarmAnimal
    {
        public Cow()
           : base("Cow") {}

        public override string DoThing()
        {
            return "The cow says moo!";
        }


    }
}
