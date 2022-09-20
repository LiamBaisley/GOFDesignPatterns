using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.ChainOfResponsibility
{
    internal class FizzHandler: Handler
    {
        public override void HandleNumbers(int num)
        {
            if (num % 3 == 0)
                Console.WriteLine("Fizz");
            else if (successor != null)
                successor.HandleNumbers(num);
        }
    }
}
