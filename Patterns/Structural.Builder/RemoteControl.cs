using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Builder
{
    internal abstract class RemoteControl
    {
        protected LEDTV ledtv;

        protected RemoteControl(LEDTV letTv)
        {
            ledtv = letTv;
        }

        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channel);
    }
}
