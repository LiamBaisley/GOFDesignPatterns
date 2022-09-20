using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.ChainOfResponsibility
{
    internal class BuzzHandler: Handler
    {
        public override void HandleNumbers(int num)
        {
            if(num % 5 == 0)
                Console.WriteLine("Buzz");
            else if(successor != null)
                successor.HandleNumbers(num);
        }
    }
}
