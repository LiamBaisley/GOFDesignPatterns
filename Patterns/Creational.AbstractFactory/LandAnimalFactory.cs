using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory
{
    internal class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string AnimalType)
        {
            IAnimal animal = null;
            if (AnimalType.ToLower().Equals("cat"))
            {
                animal = new Cat();
            }
            else if (AnimalType.ToLower().Equals("dog"))
            {
                animal = new Dog();
            }
            return animal;
        }
    }
}
