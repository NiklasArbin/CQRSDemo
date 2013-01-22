using System;
using NServiceBus;

namespace Messages
{
    public class Event : IEvent
    {
        public Guid Id { get; set; }
    }
}