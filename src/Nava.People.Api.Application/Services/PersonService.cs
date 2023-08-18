using AutoMapper;
using Microsoft.Extensions.Configuration;
using Nava.People.Api.Application.DTOs;
using Nava.People.Api.Application.Interfaces;
using Nava.People.Api.Domain.Entities;
using Nava.People.Api.Domain.Interfaces;
using System.Net.Http;
using System.Security.Principal;
using System.Text.Json;

namespace Nava.People.Api.Application.Services

{
    public class PersonService : IPersonService
    {
        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;
        private readonly IConfiguration _configuration;

        public PersonService(IMapper mapper, IPersonRepository personRepository, IConfiguration configuration)
        {
            _mapper = mapper;
            _personRepository = personRepository;
            _configuration = configuration;
         
        }

        public async Task<IEnumerable<PersonDTO>> GetAllPeople()
        {
            var people = await _personRepository.GetAllPeople();

            var mapPeople = _mapper.Map<List<PersonDTO>>(people);

            return mapPeople;
        }

        public async  Task<PersonDTO> GetPersonByDocument(string document)
        {
            var person = await _personRepository.GetPersonByDocument(document);
            var mapPerson = _mapper.Map<PersonDTO>(person);

            return mapPerson;
        }

        
    }
}