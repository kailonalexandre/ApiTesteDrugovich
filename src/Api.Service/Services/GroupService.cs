using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Group;
using Api.Domain.Models;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Service.Services
{
    public class GroupService : IGroupService
    {
        private IRepository<GroupEntity> _repository;
        private IUserService _userService;
        public GroupService(IRepository<GroupEntity> repository, IUserService userService)
        {
            _repository = repository;
            _userService = userService;
        }
        private async Task<bool> ValidateUser(string token)
        {
            var userId = _repository.GetUserIDFromToken(token);
            var user = await _userService.Get(userId);

            if (user == null)
                return false;
            if (user.Level == RoleLevel.Two)
                return true;

            return false;
        }
        public async Task<bool> Delete(Guid id, string token)
        {
            if (!await ValidateUser(token))
                return false;

            return await _repository.DeleteAsync(id);
        }

        public async Task<GroupEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<GroupEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<GroupEntity> Post(GroupEntity user, string token)
        {
            if (!await ValidateUser(token))
                return null;
            return await _repository.InsertAsync(user);
        }

        public async Task<GroupEntity> Put(GroupEntity user, string token)
        {
            if (!await ValidateUser(token))
                return null;
            return await _repository.UpdateAsync(user);
        }


    }
}
