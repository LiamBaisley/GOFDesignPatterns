using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.Iterator
{
    internal class Channel
    {
        public double Frequency { get; set; }
        public ChannelTypeEnum TYPE { get; set; }

        public Channel(double Frequency, ChannelTypeEnum type)
        {
            this.Frequency = Frequency;
            this.TYPE = type;
        }

        public string ToString()
        {
            return $"Frequency = {this.Frequency}, Type = {TYPE}";
        }
    }
}
