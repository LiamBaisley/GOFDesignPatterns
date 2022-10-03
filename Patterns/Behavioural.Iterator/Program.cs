// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using Behavioural.Iterator;


//<Summary>
//According to GOF: "The iterator pattern allows us to access the elements of an aggregate object without exposing its underlying representation"
//</Summary>

IChannelCollection channels = populateChannels();
IChannelIterator iterator = channels.iterator(ChannelTypeEnum.All);
while (iterator.HasNext())
{
    Channel c = iterator.Next();
    Console.WriteLine($"Channel is {c.ToString()}");
}

Console.WriteLine("**************");
//Iteration for specific channels
IChannelIterator sportIterator = channels.iterator(ChannelTypeEnum.Sport);
while (sportIterator.HasNext())
{
    Channel c = sportIterator.Next();
    Console.WriteLine($"Sport channel is {c.ToString()}");
}



ChannelCollection populateChannels()
{
    ChannelCollection channels = new ChannelCollection();
    channels.AddChannel(new Channel(98.5, ChannelTypeEnum.Sport));
    channels.AddChannel(new Channel(99.5, ChannelTypeEnum.Kids));
    channels.AddChannel(new Channel(100.5, ChannelTypeEnum.Soaps));
    channels.AddChannel(new Channel(101.5, ChannelTypeEnum.Movie));
    channels.AddChannel(new Channel(102.5, ChannelTypeEnum.Soaps));
    channels.AddChannel(new Channel(103.5, ChannelTypeEnum.Kids));
    channels.AddChannel(new Channel(104.5, ChannelTypeEnum.Sport));
    channels.AddChannel(new Channel(105.5, ChannelTypeEnum.Movie));
    channels.AddChannel(new Channel(106.5, ChannelTypeEnum.Sport));
    return channels;
}