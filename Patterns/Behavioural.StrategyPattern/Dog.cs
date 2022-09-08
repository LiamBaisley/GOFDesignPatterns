using Behvaioural.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.StrategyPattern
{
    internal class Dog : IAnimal
    {
        public string MakeSound()
        {
            return "Bork Bork!";
        }
    }
}
