using MassTransit;

using Microsoft.AspNetCore.Mvc;

using Person.Application.Service;
using Person.Model.Models;
using System.Data;

namespace Person.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PersonController : ControllerBase
    {

        private readonly IPersonService _personService;
        private readonly IPublishEndpoint _publishEndpoint;
        private readonly ISendEndpointProvider _sendEndpointProvider;


        public PersonController(IPublishEndpoint publishEndpoint, ISendEndpointProvider sendEndpointProvider, IPersonService personService)
        {
            _personService = personService;
            _publishEndpoint = publishEndpoint;
            _sendEndpointProvider = sendEndpointProvider;
        }

        [HttpPost]
        public async Task<IActionResult> Add( [FromBody] PersonModel person)
        {

            await _personService.Add(person);
            return Ok();
        }
        [HttpPost("delete")]
        public async Task<IActionResult> Delete(PersonModel person)
        {
            await _personService.Delete(person);
            return Ok();
        }
        [HttpPost("update")]
        public async Task<IActionResult> Update(PersonModel person)
        {
            await _personService.Update(person);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            await _personService.GetAll();
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            await _personService.GetById(id);
            return Ok();
        }

    }
}
