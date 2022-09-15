using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Builder
{
    internal class SamsungTV: LEDTV
    {
        public void SwitchOn()
        {
            Console.WriteLine("Turning on the Samsung TV");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Turning off the Samsung TV");
        }

        public void SetChannel(int channelNumber)
        {
            Console.WriteLine($"Changing the samsung TV to {channelNumber}");
        }
    }
}
