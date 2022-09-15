using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Builder
{
    internal class SamsungRemote:RemoteControl
    {
        public SamsungRemote(LEDTV letTv) : base(letTv)
        {
        }

        public override void SwitchOn()
        {
            ledtv.SwitchOn();
        }

        public override void SwitchOff()
        {
            ledtv.SwitchOff();
        }

        public override void SetChannel(int channel)
        {
            ledtv.SetChannel(channel);
        }
    }
}
