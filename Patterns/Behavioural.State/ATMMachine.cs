using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.State
{
    internal class ATMMachine: IState
    {
        public IState ATMState { get; set; }

        public ATMMachine()
        {
            ATMState = new CardNotInsertedState();
        }
        public void InsertCard()
        {
            ATMState.InsertCard();
            

            if (ATMState is CardNotInsertedState)
            {
                ATMState = new CardInsertedState();
                Console.WriteLine("ATM Machine internal state has been moved to : "
                                  + ATMState.GetType().Name);
            }
        }

        public void EjectCard()
        {
            ATMState.EjectCard();

            if (ATMState is CardInsertedState)
            {
                ATMState = new CardNotInsertedState();
                Console.WriteLine("ATM Machine internal state has been moved to : "
                                  + ATMState.GetType().Name);
            }
        }

        public void EnterPin()
        {
            ATMState.EnterPin();
        }
    }
}
