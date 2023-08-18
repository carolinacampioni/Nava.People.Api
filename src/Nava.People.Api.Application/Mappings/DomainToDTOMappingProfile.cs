using AutoMapper;
using Nava.People.Api.Application.DTOs;
using Nava.People.Api.Domain.Entities;


namespace Nava.People.Api.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Person, PersonDTO>().ReverseMap();

        }
    }
}
