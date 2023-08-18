using Moq;
using Xunit.Abstractions;
using Nava.People.Api.Domain.Entities;
using Nava.People.Api.Persistence.Repositories;
using Nava.People.Api.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace Nava.People.Api.Infrasctructure.Tests
{
    public class PersonRepositoryTests
    {
        private readonly IPersonRepository _personRepository;
        public ITestOutputHelper OutPutConsole;

        public PersonRepositoryTests(ITestOutputHelper _outPutConsole)
        {

            var mockConfiguration = new Mock<IConfiguration>();
            mockConfiguration.Setup(c => c["DataSettings:PeopleJsonFilePath"]).Returns("..\\..\\database\\people.json");
            // Add other configuration settings as needed

            var services = new ServiceCollection();
            services.AddSingleton(mockConfiguration.Object);
            services.AddTransient<IPersonRepository, PersonRepository>();
            var serviceProvider = services.BuildServiceProvider();

            _personRepository = serviceProvider.GetService<IPersonRepository>();


            OutPutConsole = _outPutConsole;
            OutPutConsole.WriteLine("Constructor invoked.");
            //Injetando dependências no construtor;
        }


        [Fact]
        public void TestGetAllPeopleRepository()
        {
            //Arrange         

            //Act
            var people = _personRepository.GetAllPeople();

            //Assert
            Assert.NotNull(people);
        }

        [Fact]
        public void TestGetPeopleByDocumentRepository()
        {
            //Arrange

            //Act
           var person = _personRepository.GetPersonByDocument("123456789");


            //Assert
            Assert.NotNull(person);
            

        }
    }
}



