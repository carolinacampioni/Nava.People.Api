using Nava.People.Api.Application.DTOs;
using Nava.People.Api.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Nava.People.Api.Application.Services;
using Nava.People.Api.Domain.Entities;
using Microsoft.AspNetCore.Authorization;

namespace Nava.People.Api.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = "BasicAuthentication")]
    public class PersonController : ControllerBase
    {

        private readonly IPersonService _personService;
        private readonly IConfiguration _configuration;


        public PersonController(IPersonService personService, IConfiguration configuration)
        {
            _configuration = configuration;
            _personService = personService;
        }

        [HttpGet]
        public ActionResult<List<Person>> GetAllPeople()
        {
            var people = _personService.GetAllPeople();
            return Ok(people);
        }

        [HttpGet("{document}")]
        public async Task<ActionResult<Person>> GetPersonByDocument(string document)
        {
            var person = await _personService.GetPersonByDocument(document);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }
    }
}