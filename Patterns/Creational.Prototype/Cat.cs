using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Prototype
{
    internal class Cat
    {
        //Since there are a couple of kinds of cats this could be cat, lion, leopard etc
        public string Kind { get; set; }
        public string Size { get; set; }

        public Cat GetClone()
        {
            //This returns a clone of the class, so that edits can be made without modifying other instances. 
            return (Cat)this.MemberwiseClone();
        }
    }
}
