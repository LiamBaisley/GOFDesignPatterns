using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.State
{
    internal interface IState
    {
        void InsertCard();
        void EjectCard();
        void EnterPin();
    }
}
