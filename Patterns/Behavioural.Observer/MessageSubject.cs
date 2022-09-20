using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.Observer
{
    internal class MessageSubject: ISubject
    {
        List<IObserver> observers = new List<IObserver>();
        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(string message)
        {
            observers.ForEach(o => o.MessageSent(message));
        }
    }
}
