using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.Iterator
{
    internal class ChannelCollection: IChannelCollection
    {
        private List<Channel> channels;

        public ChannelCollection()
        {
            channels = new List<Channel>();
        }

        public void AddChannel(Channel c)
        {
            channels.Add(c);
        }

        public void RemoveChannel(Channel c)
        {
            channels.Remove(c);
        }


        public IChannelIterator iterator(ChannelTypeEnum type)
        {
            return new ChannelIterator(type, this.channels);
        }

        //Should only be accessible to the channel collection
        private class ChannelIterator : IChannelIterator
        {
            public ChannelTypeEnum Type { get; set; }
            public List<Channel> channels { get; set; }
            public int position { get; set; }

            public ChannelIterator(ChannelTypeEnum type, List<Channel> channels)
            {
                this.Type = type;
                this.channels = channels;
            }
            public bool HasNext()
            {
                while (position < channels.Count)
                {
                    Channel c = channels[position];
                    if (c.TYPE == this.Type || this.Type == ChannelTypeEnum.All)
                    {
                        return true;
                    }
                    else
                    {
                        position++;
                    }

                }
                return false;
            }

            public Channel Next()
            {
                Channel c = channels[position];
                position++;
                return c;
            }
        }
    }
    
}
