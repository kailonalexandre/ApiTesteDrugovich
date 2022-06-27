using Api.Domain.Dtos;
using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Client
{
    public interface IClientService
    {
        Task<ClientEntity> Get(Guid id);
        Task<IEnumerable<ClientEntity>> GetAll();
        Task<ClientEntity> Post(ClientInsertDto user);
        Task<ClientEntity> Put(ClientEntity user, string token);
        Task<bool> Delete(Guid id);
        Task<ClientEntity> UpsertGroup(Guid id, Guid groupId);
    }
}
