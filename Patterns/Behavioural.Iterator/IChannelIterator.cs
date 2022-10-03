using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.Iterator
{
    internal interface IChannelIterator
    {
        public bool HasNext();
        public Channel Next();
    }
}
