using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory
{
    internal abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(string AnimalType);

        public static AnimalFactory CreateAnimalfactory(string AnimalType)
        {
            if (AnimalType.ToLower().Equals("sea"))
            {
                return new SeaAnimalFactory();
            }
            else if(AnimalType.ToLower().Equals("land"))
            {
                return new LandAnimalFactory();
            }
            else
            {
                return null;
            }
        }
    }
}
