using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.Command
{
    internal class RemoteControl
    {
        public void Invoke(ICommand command)
        {
            command.Execute();
        }
    }
}
