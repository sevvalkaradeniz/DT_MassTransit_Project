using MassTransit;
using Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Service.Consumers
{
    internal class PersonUpdatedEventConsumer : IConsumer<PersonUpdatedEvent>
    {
        public Task Consume(ConsumeContext<PersonUpdatedEvent> context)
        {
            throw new NotImplementedException();
        }
    }
}
