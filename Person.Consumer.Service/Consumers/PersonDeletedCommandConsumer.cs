using MassTransit;
using Person.Model.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.Consumer.Service.Consumers
{
    public class PersonDeletedCommandConsumer : IConsumer<PersonDeletedCommand>
    {
        public Task Consume(ConsumeContext<PersonDeletedCommand> context)
        {
            throw new NotImplementedException();
        }
    }
}
