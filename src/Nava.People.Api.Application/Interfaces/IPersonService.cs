using Nava.People.Api.Application.DTOs;


namespace Nava.People.Api.Application.Interfaces
{
    public interface IPersonService
    {
        Task<IEnumerable<PersonDTO>> GetAllPeople();

        Task<PersonDTO> GetPersonByDocument(string document);

    }
}
