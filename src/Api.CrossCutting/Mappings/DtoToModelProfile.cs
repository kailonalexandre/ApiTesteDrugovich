using Api.Domain.Dtos;
using AutoMapper;
using Domain.Dtos;
using Domain.Models;

namespace CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<ClientModel, ClientDto>()
                .ReverseMap();
            CreateMap<ClientModel, ClientInsertDto>()
                .ReverseMap();

            CreateMap<GroupModel, GroupDto>()
               .ReverseMap();
            CreateMap<GroupModel, GroupInsertDto>()
                .ReverseMap();
        }
    }
}
