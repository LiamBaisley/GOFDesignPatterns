using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{
    internal class Cat : AnimalBuilder
    {

        public override void SetCanFetch()
        {
            animal.CanFetch = false;
        }

        public override void SetNoise()
        {
            animal.Sound = "Meow Meow";
        }

        public override void SetRetractableClaws()
        {
            animal.RetractableClaws = true;
        }
    }
}
