using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{
    internal class AnimalDirector
    {
        public Animal MakeAnimal(AnimalBuilder animalBuilder)
        {
            animalBuilder.CreateNewAnimal();
            animalBuilder.SetRetractableClaws();
            animalBuilder.SetCanFetch();
            animalBuilder.SetNoise();

            return animalBuilder.Getanimal();
        }
    }
}
