using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.Iterator
{
    internal interface IChannelCollection
    {
        public void AddChannel(Channel c);
        public void RemoveChannel(Channel c);
        public IChannelIterator iterator(ChannelTypeEnum type);
    }
}
