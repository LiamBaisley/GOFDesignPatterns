using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.Mediator
{
    internal static class Mediator
    {
        public static void SendCommands(string animal, string command)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            if (animal.ToLower().Equals("dog"))
            {
                dog.DoCommand(command);
            }
            else if (animal.ToLower().Equals("cat"))
            {
                cat.DoCommand(command);
            }
            else
            {
                cat.DoCommand(command);
                dog.DoCommand(command);
            }
        }
    }
}
