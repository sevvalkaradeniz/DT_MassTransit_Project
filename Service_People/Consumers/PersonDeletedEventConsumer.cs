using MassTransit;
using Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Person.Consumers
{
    public class PersonDeletedEventConsumer : IConsumer<PersonDeletedEvent>
    {
        public Task Consume(ConsumeContext<PersonDeletedEvent> context)
        {
            throw new NotImplementedException();
        }
    }
}
