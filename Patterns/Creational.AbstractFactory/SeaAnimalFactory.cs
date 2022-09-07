using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory
{
    internal class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string AnimalType)
        {
            IAnimal animal = null;
            if (AnimalType.ToLower().Equals("whale"))
            {
                animal = new Whale();
            }
            else if (AnimalType.ToLower().Equals("fish"))
            {
                animal = new Fish();
            }
            return animal; ;
        }
    }
}
