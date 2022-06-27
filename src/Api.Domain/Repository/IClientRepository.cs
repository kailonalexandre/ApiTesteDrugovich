using Api.Domain.Entities;
using Api.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Repository
{
    public interface IClientRepository : IRepository<ClientEntity>
    {
        Task<IEnumerable<ClientEntity>> GetAllByGroup(Guid groupId);
    }
}
