using Behvaioural.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.StrategyPattern
{
    internal class AnimalContext
    {
        private IAnimal Animal;
        
        public AnimalContext(IAnimal animal)
        {
            this.Animal = animal;
        }

        //This method is used to set a new strategy when an instance of AnimalContext already exists
        public void SetStrategy(IAnimal animal)
        {
            this.Animal = animal;
        }

        public string DoSound()
        {
            return Animal.MakeSound();
        }
    }
}
