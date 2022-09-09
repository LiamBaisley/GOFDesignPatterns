using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Proxy
{
    internal class RealInternet: IInternet
    {
        public void ConnectTo(string Host)
        {
            Console.WriteLine($"Connecting to {Host}...");
        }
    }
}
