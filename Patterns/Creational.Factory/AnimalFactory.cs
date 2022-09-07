using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory
{
    internal class AnimalFactory
    {
        public static IAnimal GetAnimal(string Animal)
        {
            IAnimal animal = null;
            if (Animal.ToLower().Equals("cat"))
            {
                animal = new Cat();
            }
            else if (Animal.ToLower().Equals("dog"))
            {
                animal = new Dog();
            }
            return animal; ;
        }
    }
}
