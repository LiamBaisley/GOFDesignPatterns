using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{
    internal class Dog : AnimalBuilder
    {
        public override void SetCanFetch()
        {
            animal.CanFetch = true;
        }

        public override void SetNoise()
        {
            animal.Sound = "Bork Bork";
        }

        public override void SetRetractableClaws()
        {
            animal.RetractableClaws = false;
        }
    }
}
