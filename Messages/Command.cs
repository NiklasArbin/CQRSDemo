using System;
using NServiceBus;

namespace Messages
{
    public class Command: ICommand
    {
        public Guid Id { get; set; }
    }
}
