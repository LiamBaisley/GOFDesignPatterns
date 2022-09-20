using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.Observer
{
    internal class MessageObserver: IObserver
    {
        public void MessageSent(string message)
        {
            Console.WriteLine($"New message received from Subject: {message}");
        }
    }
}
