using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.State
{
    internal class CardInsertedState: IState
    {
        public void InsertCard()
        {
            Console.WriteLine("Card already in slot, another cannot be accepted.");
        }

        public void EjectCard()
        {
            Console.WriteLine("Card being ejected");
        }

        public void EnterPin()
        {
            Console.WriteLine("Pin correct");
        }
    }
}
