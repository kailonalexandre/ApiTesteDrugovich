using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Group
{
    public interface IGroupService
    {
        Task<GroupEntity> Get(Guid id);
        Task<IEnumerable<GroupEntity>> GetAll();
        Task<GroupEntity> Post(GroupEntity user, string token);
        Task<GroupEntity> Put(GroupEntity user, string token);
        Task<bool> Delete(Guid id, string token);

    }
}
