using MassTransit;
using Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Service.Consumers
{
    public class PersonAddedEventConsumer : IConsumer<PersonAddedEvent>
    {
        public Task Consume(ConsumeContext<PersonAddedEvent> context)
        {
            throw new NotImplementedException();
        }
    }
}
