using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{
    internal abstract class AnimalBuilder
    {
        protected Animal animal;

        public abstract void SetNoise();
        public abstract void SetCanFetch();
        public abstract void SetRetractableClaws();

        public void CreateNewAnimal()
        {
            animal = new Animal();
        }

        public Animal Getanimal()
        {
            return animal;
        }
    }
}
