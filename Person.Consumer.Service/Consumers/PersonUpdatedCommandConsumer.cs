using MassTransit;
using Person.Model.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.Consumer.Service.Consumers
{
    public class PersonUpdatedCommandConsumer : IConsumer<PersonUpdatedCommand>
    {
        public Task Consume(ConsumeContext<PersonUpdatedCommand> context)
        {
            throw new NotImplementedException();
        }
    }
}
