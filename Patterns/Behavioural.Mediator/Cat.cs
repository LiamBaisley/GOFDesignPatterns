using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.Mediator
{
    internal class Cat: IAnimal
    {
        public void DoCommand(string command)
        {
            Console.WriteLine($"Uh Oh, it looks like catto is doing a {command}");
        }
    }
}
