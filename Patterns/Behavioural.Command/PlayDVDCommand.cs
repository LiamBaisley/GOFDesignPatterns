using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.Command
{
    internal class PlayDVDCommand: ICommand
    {
        public void Execute()
        {
            Console.WriteLine("The DVD is playing now");
        }
    }
}
