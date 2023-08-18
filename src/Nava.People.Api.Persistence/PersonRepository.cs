using Microsoft.Extensions.Configuration;
using Nava.People.Api.Domain.Entities;
using Nava.People.Api.Domain.Interfaces;


namespace Nava.People.Api.Persistence.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private List<Person> people;

        public PersonRepository(IConfiguration configuration)
        {
            var dataUtility = new DataUtility(configuration["DataSettings:PeopleJsonFilePath"]);
            people = dataUtility.LoadPeopleDataFromJsonFileAsync().GetAwaiter().GetResult();
        }


        public async Task<IEnumerable<Person>> GetAllPeople()
        {
            return people;

        }

        public async Task<Person> GetPersonByDocument(string document)
        {
            return await Task.Run(() => people.Find(p => p.Document == document));
        }
    }
}