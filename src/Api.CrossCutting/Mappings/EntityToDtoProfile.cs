using Api.Domain.Dtos;
using Api.Domain.Entities;
using AutoMapper;
using Domain.Dtos;

namespace CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<ClientDto, ClientEntity>()
                .ReverseMap();

            CreateMap<ClientInsertDto, ClientEntity>()
                .ReverseMap();

            CreateMap<GroupDto, GroupEntity>()
                .ReverseMap();

            CreateMap<GroupInsertDto, GroupEntity>()
                .ReverseMap();
        }
    }
}
