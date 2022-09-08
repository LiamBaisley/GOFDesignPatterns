using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.Mediator
{
    internal class Dog: IAnimal
    {
        public void DoCommand(string command)
        {
            Console.WriteLine($"Uh Oh! Looks like doggo is doing a {command}");
        }
    }
}
