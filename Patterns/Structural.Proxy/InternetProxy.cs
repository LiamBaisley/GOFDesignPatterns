using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Proxy
{
    internal class InternetProxy: IInternet
    {
        private IInternet internet = new RealInternet();
        private static List<string> BannedSites;

        //We can add our own functionality to the internet, allowing us to block certain sites. 
        public InternetProxy()
        {
            BannedSites = new List<string>();
            BannedSites.Add("abc.com");
            BannedSites.Add("StackOverflow.com");
            BannedSites.Add("Github.com");
        }
        public void ConnectTo(string Host)
        {
            if (BannedSites.Contains(Host))
            {
                Console.WriteLine("Uh oh that site isn't allowed!");
            }
            else
            {
                internet.ConnectTo(Host);
            }
        }
    }
}
