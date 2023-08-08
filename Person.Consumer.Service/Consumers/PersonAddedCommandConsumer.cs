
using Data_Access.Repository;
using Data_Access.Repository.Base;
using MassTransit;
using Person.Application.Service;
using Person.Model.Command;
using Person.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.Consumer.Service.Consumers
    
{
    public class PersonAddedCommandConsumer : IConsumer<IPersonAddedCommand>
    {
        IPersonService _personService;

        public PersonAddedCommandConsumer(IPersonService personService)
        {
            _personService = personService;
        }

        public async Task Consume(ConsumeContext<IPersonAddedCommand> context)
        {
            var newPerson = new PersonModel
            {
               Name=context.Message.Name,
               Surname=context.Message.Surname,
               Age=context.Message.Age,
               Birthday=context.Message.Birthday,
               Gender=context.Message.Gender,
               City=context.Message.City,
            };

            Console.WriteLine(context.Message.Age);
            await _personService.AddPerson(newPerson);
            
           
        }
    }
}
