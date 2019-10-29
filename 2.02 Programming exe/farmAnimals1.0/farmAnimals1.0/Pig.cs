using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmAnimals1._0
{
    class Pig : FarmAnimal
    {
        public Pig()
           : base("Pig") { }

        public override string DoThing()
        {
            return "The pig says oink!";
        }
    }
}
