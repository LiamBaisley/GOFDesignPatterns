using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Builder
{
    internal class SonyTV: LEDTV
    {
        public void SwitchOn()
        {
            Console.WriteLine("Turning on the Sony TV");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Turning off the Sony TV");
        }

        public void SetChannel(int channelNumber)
        {
            Console.WriteLine($"Changing the sony Tv to channel {channelNumber}");
        }
    }
}
