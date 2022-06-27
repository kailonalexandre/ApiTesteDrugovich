using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Data.Implementations
{
    public class ClientImplementation : BaseRepository<ClientEntity>, IClientRepository
    {
        private DbSet<ClientEntity> _dataset;

        public ClientImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<ClientEntity>();
        }

        public async Task<IEnumerable<ClientEntity>> GetAllByGroup(Guid groupId)
        {
            return await _dataset.Where(x => x.GroupId == groupId).ToListAsync();
        }
    }
}
