using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Messages;
using NServiceBus;

namespace ViewModelUpdater
{
    public class EventListner : IHandleMessages<Event>
    {

        public void Handle(Event message)
        {
            throw new NotImplementedException();
        }
    }
}
