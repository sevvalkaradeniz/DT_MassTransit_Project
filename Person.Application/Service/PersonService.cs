using Data_Access.Repository;
using Data_Access.Repository.Base;
using MassTransit;
using Person.Model;
using Person.Model.Command;
using Person.Model.Models;

namespace Person.Application.Service
{
    public class PersonService : IPersonService
    {
        private readonly IPublishEndpoint _publishEndpoint;
        private readonly ISendEndpointProvider _sendEndpointProvider;
        private readonly IPersonRepository _personRepository;

        public PersonService(IPublishEndpoint publishEndpoint, ISendEndpointProvider sendEndpointProvider, IPersonRepository personRepository)
        {
            _publishEndpoint = publishEndpoint;
            _sendEndpointProvider = sendEndpointProvider;
            _personRepository = personRepository;
        }

        public PersonService(IPublishEndpoint publishEndpoint, ISendEndpointProvider sendEndpointProvider)
        {
            _publishEndpoint = publishEndpoint;
            _sendEndpointProvider = sendEndpointProvider;

        }

        public async Task Add(PersonModel person)
        {
            var PersonAddedCommand = new PersonAddedCommand
            {
                Name = person.Name,
                Surname = person.Surname,
                Age = person.Age,
                Birthday = person.Birthday,
                Gender= person.Gender,
                City = person.City,
                Message="Person added succesfully"
            };
            
            await _personRepository.AddAsync(person);

            var sendEndPoint = await _sendEndpointProvider.GetSendEndpoint(new Uri
                   ($"queue:{RabbitMQSettings.PersonAddedCommandSendQueueName}"));
           
             await sendEndPoint.Send<IPersonAddedCommand>(PersonAddedCommand);
            
        }

        public async Task AddPerson(PersonModel person)
        {
            //person will be send to data access layer
            await _personRepository.AddAsync(person);
        }

        public async Task Delete(PersonModel person)
        {
            var PersonDeletedCommand = new PersonDeletedCommand {
                Name = person.Name,
                Surname = person.Surname,
                Age = person.Age,
                Birthday = person.Birthday,
                City = person.City,
                Gender = person.Gender,
                PersonId = person.Id,
                Message = "Person deleted succesfully"
            };
            //await _publishEndpoint.Publish(PersonDeletedCommand);
        }

        public Task<IEnumerable<PersonModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PersonModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Update(PersonModel person)
        {
            var PersonUpdatedCommand = new PersonUpdatedCommand
            {
                Name = person.Name,
                Surname = person.Surname,
                Age = person.Age,
                Birthday = person.Birthday,
                City = person.City,
                Gender = person.Gender,
                PersonId = person.Id,
                Message = "Person updated succesfully"
            };

            //await _publishEndpoint.Publish(PersonUpdatedCommand);
        }
    }



        
}
