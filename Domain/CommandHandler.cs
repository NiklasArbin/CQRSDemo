using Messages;
using NServiceBus;

namespace Domain
{
    public class CommandHandler : IHandleMessages<Messages.Command>
    {
        public IBus Bus { get; set; }

        public void Handle(Command message)
        {
            Bus.Publish(new Event { Id = message.Id });
        }
    }
}
