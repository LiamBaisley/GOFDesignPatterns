using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.Mediator
{
    internal class Human
    {
        public void IssueCommand(string command, string animal)
        {
            Mediator.SendCommands(animal, command);
        }
    }
}
