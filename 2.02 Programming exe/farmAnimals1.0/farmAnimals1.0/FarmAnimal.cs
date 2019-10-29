using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmAnimals1._0
{
    abstract class FarmAnimal
    {
        private String animalName;
        public String AnimalName
        {
            get { return animalName; }
            set { animalName = value; }
        }

        public FarmAnimal(String name)
        {
            animalName = name;
        }

        abstract public string DoThing();

    }
}
