using MassTransit;
using Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Person.Consumers
{
    public class PersonAddedEventConsumer : IConsumer<PersonAddedEvent>
    {
        public Task Consume(ConsumeContext<PersonAddedEvent> context)
        {
            var personAddedEvent = context.Message;
            Console.Write(personAddedEvent.Name.ToString());
            throw new NotImplementedException();
        }
    }
}
