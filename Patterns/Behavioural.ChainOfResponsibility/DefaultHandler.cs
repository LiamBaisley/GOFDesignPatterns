using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.ChainOfResponsibility
{
    internal class DefaultHandler: Handler
    {
        public override void HandleNumbers(int num)
        {
            if(num % 5 != 0 && num % 3 != 0)
                Console.WriteLine(num);
        }
    }
}
