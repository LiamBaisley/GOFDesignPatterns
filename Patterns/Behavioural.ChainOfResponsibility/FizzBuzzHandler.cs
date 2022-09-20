using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Behavioural.ChainOfResponsibility
{
    internal class FizzBuzzHandler: Handler
    {
        public override void HandleNumbers(int num)
        {
            if(num % 5 == 0 && num % 3 == 0)
                Console.WriteLine("FizzBuzz");
            else if(successor != null)
                successor.HandleNumbers(num);
        }
    }
}
