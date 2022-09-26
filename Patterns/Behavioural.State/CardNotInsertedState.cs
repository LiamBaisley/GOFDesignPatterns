using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.State
{
    internal class CardNotInsertedState: IState
    {
        public void InsertCard()
        {
            Console.WriteLine("Card inserted...");
        }

        public void EjectCard()
        {
            Console.WriteLine("No card inserted, no card can be ejected");
        }

        public void EnterPin()
        {
            Console.WriteLine("No pin can be excepted as no card has been inserted.");
        }
    }
}
